using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;

namespace MediaManager.ViewModel
{
    public class MovieViewModel : ViewModelBase
    {
        private readonly int _mMovieId;
        private readonly RelayCommand _mLoadMovieCommand;
        private readonly BitmapImage _mPoster;

        public MovieViewModel(int movieId, BitmapImage poster, MovieInfoViewModel context)
        {
            _mMovieId = movieId;
            _mPoster = poster;
            Context = context;
            _mLoadMovieCommand = new RelayCommand(LoadMovieExecute);
        }

        private void LoadMovieExecute(object obj)
        {
            Context.UpdateMovieInfo(_mMovieId);
        }

        public BitmapImage Poster
        {
            get { return _mPoster; }
        }

        public int MovieId
        {
            get { return _mMovieId; }
        }

        public RelayCommand LoadMovieCommand
        {
            get { return _mLoadMovieCommand; }
        }

        public MovieInfoViewModel Context { get; set; }
    }
}
