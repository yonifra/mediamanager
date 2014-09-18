using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using MediaManager.Model;
using WatTmdb.V3;

namespace MediaManager.ViewModel
{
    public class MovieInfoViewModel : ViewModelBase
    {
        #region Members

        private readonly IDataService _dataService;
        private readonly Tmdb _api;
        private readonly TmdbConfiguration _tmdbConfig;
        private string _mMovieName;
        private string _mMovieSynopsis;
        private string _mMovieReleaseDate;
        private string _mMovieToSearch;
        private string _mMovieYear;
        private string _mMovieRating;
        private string _mTagline;
        private string _mMovieGenre;
        private Uri _mTrailerSource;
        private bool _mShowTrailer;
        private bool _mShowInfo;
        private bool _mIsLoading;
        private bool _mIsLoaded;
        private int _mRuntime;
        private int _mRevenue;
        private BitmapImage _mActorImage;
        private BitmapImage _mMoviePoster;
        private BitmapImage _mMovieBackPoster;
        private MovieResult _mSelectedMovie;
        private RelayCommand _mSearchMovieCommand;
        private List<Cast> _mMovieCastMembers;
        private ObservableCollection<MovieResult> _mMovieResults;
        private TmdbMovieSearch _searchResults;
        private TmdbSimilarMovies _mSimilarMovies;
        private TmdbMovie _mCurrentMovie;

        #endregion Members

        #region Constructor

        public MovieInfoViewModel()
        {
            InitializeCollections();

            _api = new Tmdb("6f8f5ded34fa534314a23fa7d705681b", "en");
            _tmdbConfig = _api.GetConfiguration();
            _mSelectedMovie = new MovieResult();
            SimilarMoviesCollection = new ObservableCollection<MovieViewModel>();
            IsLoading = false;
            IsLoaded = false;

            BackgroundPoster = new BitmapImage(new Uri(@"pack://application:,,,/MediaManager;component/Resources/firstbackground.jpg"));
        }

        public MovieInfoViewModel(IDataService dataService)
            : this()
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                });
        }

        #endregion Constructor

        private void InitializeCollections()
        {
            _mMovieCastMembers = new List<Cast>();
        }

        #region Properties

        public List<Cast> CastMembers
        {
            get { return _mMovieCastMembers; }
            set
            {
                if (_mMovieCastMembers != value)
                {
                    _mMovieCastMembers = value;
                    RaisePropertyChanged("CastMembers");
                }
            }
        }

        public string MovieToSearch
        {
            get
            {
                return _mMovieToSearch;
            }
            set
            {
                if (_mMovieToSearch != value)
                {
                    _mMovieToSearch = value;
                    RaisePropertyChanged("MovieToSearch");
                }
            }
        }

        public string SynopsisHeader
        {
            get
            {
                return !string.IsNullOrEmpty(Synopsis) ? "Synopsis" : string.Empty;
            }
        }

        public string CastHeader
        {
            get
            {
                if (CastMembers != null && CastMembers.Count > 0)
                {
                    return "Cast";
                }

                return string.Empty;
            }
        }

        public string MovieGenre
        {
            get
            {
                return _mMovieGenre;
            }
            set
            {
                if (_mMovieGenre != value)
                {
                    _mMovieGenre = value;
                    RaisePropertyChanged("MovieGenre");
                }
            }
        }

        public bool ShowTrailer
        {
            get { return _mShowTrailer; }
            set
            {
                if (_mShowTrailer == value) return;

                _mShowTrailer = value;
                RaisePropertyChanged("ShowTrailer");
                RaisePropertyChanged("TrailerVisibility");
            }
        }

        public bool ShowInfo
        {
            get { return _mShowInfo; }
            set
            {
                if (_mShowInfo != value)
                {
                    _mShowInfo = value;
                    RaisePropertyChanged("ShowInfo");
                    RaisePropertyChanged("InfoVisibility");
                }
            }
        }

        public Visibility InfoVisibility
        {
            get
            {
                return ShowInfo ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public Visibility TrailerVisibility
        {
            get
            {
                return ShowTrailer ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public string Synopsis
        {
            get { return _mMovieSynopsis; }
            set
            {
                if (_mMovieSynopsis != value)
                {
                    _mMovieSynopsis = value;
                    RaisePropertyChanged("Synopsis");
                }
            }
        }

        public bool IsLoading
        {
            get
            {
                return _mIsLoading;
            }
            private set
            {
                if (_mIsLoading != value)
                {
                    _mIsLoading = value;
                    RaisePropertyChanged("IsLoading");
                }
            }
        }

        public bool IsLoaded
        {
            get
            {
                return _mIsLoaded;
            }
            private set
            {
                if (_mIsLoaded != value)
                {
                    _mIsLoaded = value;
                    RaisePropertyChanged("IsLoaded");
                }
            }
        }

        public ObservableCollection<MovieResult> MovieResults
        {
            get
            {
                return _mMovieResults;
            }
            private set
            {
                if (_mMovieResults != value)
                {
                    _mMovieResults = value;
                    RaisePropertyChanged("MovieResults");
                }
            }
        }

        public int Runtime
        {
            get
            {
                return _mRuntime;
            }
            private set
            {
                if (_mRuntime != value)
                {
                    _mRuntime = value;
                    RaisePropertyChanged("Runtime");
                    RaisePropertyChanged("RuntimeText");
                }
            }
        }

        public string RuntimeText
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return string.Empty;
                }

                return "Total Runtime: " + _mRuntime.ToString() + " minutes";
            }
        }

        public int Revenue
        {
            get
            {
                return _mRevenue;
            }
            private set
            {
                if (_mRevenue != value)
                {
                    _mRevenue = value;
                    RaisePropertyChanged("Revenue");
                    RaisePropertyChanged("RevenueText");
                }
            }
        }

        public string RevenueText
        {
            get
            {
                if (_mRevenue == 0)
                    return string.Empty;

                var revenueString = _mRevenue.ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
                return String.Format("Revenue: {0}", revenueString);
            }
        }

        public BitmapImage ActorImage
        {
            get
            {
                return _mActorImage;
            }
            private set
            {
                if (!(_mActorImage == value))
                {
                    _mActorImage = value;
                    RaisePropertyChanged("ActorImage");
                }
            }
        }

        public string Name
        {
            get
            {
                return _mMovieName;
            }
            private set
            {
                if (_mMovieName != value)
                {
                    _mMovieName = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public BitmapImage Poster
        {
            get
            {
                return _mMoviePoster;
            }
            private set
            {
                if (_mMoviePoster != value)
                {
                    _mMoviePoster = value;
                    RaisePropertyChanged("Poster");
                }
            }
        }

        public string Tagline
        {
            get
            {
                return _mTagline;
            }
            private set
            {
                if (_mTagline != value)
                {
                    _mTagline = value;
                    RaisePropertyChanged("Tagline");
                }
            }
        }

        public BitmapImage BackgroundPoster
        {
            get
            {
                return _mMovieBackPoster;
            }
            private set
            {
                if (_mMovieBackPoster != value)
                {
                    _mMovieBackPoster = value;
                    RaisePropertyChanged("BackgroundPoster");
                }
            }
        }

        public string Year
        {
            get
            {
                if (!string.IsNullOrEmpty(_mMovieYear))
                {
                    return "(" + _mMovieYear + ")";
                }

                return string.Empty;
            }
            set
            {
                if (_mMovieYear != value)
                {
                    _mMovieYear = value;
                    RaisePropertyChanged("Year");
                }
            }
        }

        public MovieResult SelectedMovie
        {
            get
            {
                return _mSelectedMovie;
            }
            set
            {
                if (_mSelectedMovie != value)
                {
                    _mSelectedMovie = value;

                    if (_mSelectedMovie != null)
                    {
                        RefreshMovie(_mSelectedMovie.id);
                    }

                    RaisePropertyChanged("SelectedMovie");
                }
            }
        }

        public string Rating
        {
            get
            {
                if (!string.IsNullOrEmpty(_mMovieRating))
                {
                    return "Average Rating: " + _mMovieRating + " / 10 (" + _mCurrentMovie.vote_count + " votes)";
                }

                return string.Empty;
            }
            private set
            {
                if (_mMovieRating != value)
                {
                    _mMovieRating = value;
                    RaisePropertyChanged("Rating");
                }
            }
        }

        public string ReleaseDate
        {
            get
            {
                return _mMovieReleaseDate;
            }
            private set
            {
                if (_mMovieReleaseDate != value)
                {
                    _mMovieReleaseDate = value;
                    RaisePropertyChanged("ReleaseDate");
                }
            }
        }

        public Uri TrailerSource
        {
            get
            {
                return _mTrailerSource;
            }
            set
            {
                if (!(_mTrailerSource == value))
                {
                    _mTrailerSource = value;
                    RaisePropertyChanged("TrailerSource");
                }
            }
        }

        public ICommand SearchMovieCommand
        {
            get { return _mSearchMovieCommand ?? (_mSearchMovieCommand = new RelayCommand(param => SearchMoviesAsync())); }
        }

        private void SearchMoviesAsync()
        {
            IsLoading = true;

            Task.Factory.StartNew(SearchMovies).ContinueWith(antecedent =>
                        {
                            if (_searchResults == null || _searchResults.results.Count == 0)
                            {
                                MessageBox.Show("Could not find any movies by the name \"" + MovieToSearch + "\"");
                            }
                            else
                            {
                                MovieResults = new ObservableCollection<MovieResult>(_searchResults.results);

                                if (MovieResults.Count > 0)
                                {
                                    Application.Current.Dispatcher.Invoke(new Action(() => UpdateMovieInfo(MovieResults[0].id)));
                                    //UpdateMovieInfo(MovieResults[0].id);
                                }
                            }
                        })
                        .ContinueWith(ante =>
                            {
                                IsLoading = false;
                                IsLoaded = true;
                            });
        }

        public TmdbSimilarMovies SimilarMovies
        {
            get { return _mSimilarMovies; }
            set
            {
                if (_mSimilarMovies != value)
                {
                    _mSimilarMovies = value;
                    RaisePropertyChanged("SimilarMovies");

                    Application.Current.Dispatcher.Invoke(InitializeSimilarMovies);
                }
            }
        }

        private void InitializeSimilarMovies()
        {
            SimilarMoviesCollection.Clear();

            foreach (var movie in _mSimilarMovies.results)
            {
                SimilarMoviesCollection.Add(new MovieViewModel(
                    movie.id,
                    Helper.GetImageFromUri(new Uri(
                            _tmdbConfig.images.base_url +
                            _tmdbConfig.images.poster_sizes[_tmdbConfig.images.poster_sizes.Count - 2] + movie.poster_path,
                            UriKind.Absolute)),
                            this));
            }
        }

        public ObservableCollection<MovieViewModel> SimilarMoviesCollection { get; set; }

        #endregion Properties

        #region Private Methods

        private void SearchMovies()
        {
            _searchResults = _api.SearchMovie(MovieToSearch, 1);
        }

        internal void UpdateMovieInfo(int movieId)
        {
            Name = _api.GetMovieInfo(movieId).title;
            var cast = _api.GetMovieCast(movieId);
            var movie = _api.GetMovieInfo(movieId);
            var trailers = _api.GetMovieTrailers(movieId);
            SimilarMovies = _api.GetSimilarMovies(movieId, 1);

            if (movie != null)
            {
                _mCurrentMovie = movie;

                try
                {
                    Poster = Helper.GetImageFromUri(new Uri(_tmdbConfig.images.base_url + _tmdbConfig.images.poster_sizes[_tmdbConfig.images.poster_sizes.Count - 2] + movie.poster_path, UriKind.Absolute));
                    BackgroundPoster = Helper.GetImageFromUri(new Uri(_tmdbConfig.images.base_url + _tmdbConfig.images.backdrop_sizes[_tmdbConfig.images.backdrop_sizes.Count - 2] + movie.backdrop_path, UriKind.Absolute));
                }
                catch
                {
                    Console.WriteLine("Problem loading posters for " + movie.original_title);
                }

                Revenue = movie.revenue;
                Synopsis = movie.overview;
                Tagline = movie.tagline;
                Runtime = movie.runtime;
                Rating = movie.vote_average.ToString();

                if (!String.IsNullOrEmpty(movie.release_date))
                {
                    Year = movie.release_date.Substring(0, 4);
                }

                var builder = new StringBuilder();
                if (movie.genres.Count > 1)
                {
                    for (var i = 0; i < movie.genres.Count - 1; i++)
                    {
                        builder.Append(movie.genres[i].name);
                        builder.Append(" / ");
                    }
                }

                // add the last one
                if (movie.genres.Count > 0)
                    builder.Append(movie.genres[movie.genres.Count - 1].name);

                MovieGenre = builder.ToString();
            }

            if (cast != null)
            {
                CastMembers = cast.cast;
            }

            if (MovieResults.Count > 0)
            {
                SelectedMovie = MovieResults[0];
            }

            RaisePropertyChanged("SynopsisHeader");
            RaisePropertyChanged("CastHeader");
            RaisePropertyChanged("CastMembers");
            ShowInfo = true;

            if (trailers.youtube.Count > 0)
            {
                ShowTrailer = true;
                TrailerSource = new Uri("http://www.youtube.com/embed/" + trailers.youtube[0].source, UriKind.Absolute);
            }
            else
            {
                ShowTrailer = false;
            }
        }

        #endregion Private Methods

        #region Public Methods

        public void RefreshMovie(int movieId)
        {
            UpdateMovieInfo(movieId);
        }

        #endregion Public Methods
    }
}
