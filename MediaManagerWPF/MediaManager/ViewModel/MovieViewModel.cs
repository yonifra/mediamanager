using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;

namespace MediaManager.ViewModel
{
    public class MovieViewModel : ViewModelBase
    {
        public MovieViewModel(int movieId, BitmapImage poster, MovieInfoViewModel context)
        {
            MovieId = movieId;
            Poster = poster;
            Context = context;
            LoadMovieCommand = new RelayCommand(LoadMovieExecute);
        }

        private void LoadMovieExecute(object obj)
        {
            Context.UpdateMovieInfo(MovieId);
        }

        public BitmapImage Poster { get; }
        public int MovieId { get; }
        public RelayCommand LoadMovieCommand { get; }
        public MovieInfoViewModel Context { get; set; }
    }
}
