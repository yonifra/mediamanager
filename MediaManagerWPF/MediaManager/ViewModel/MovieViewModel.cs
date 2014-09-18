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
        private readonly int mMovieId;
        private readonly RelayCommand mLoadMovieCommand;
        private readonly BitmapImage mPoster;

        public MovieViewModel(int movieId, BitmapImage poster, MovieInfoViewModel context)
        {
            mMovieId = movieId;
            mPoster = poster;
            Context = context;
            mLoadMovieCommand = new RelayCommand(LoadMovieExecute);
        }

        private void LoadMovieExecute(object obj)
        {
            Context.UpdateMovieInfo(mMovieId);
        }

        public BitmapImage Poster
        {
            get { return mPoster; }
        }

        public int MovieId
        {
            get { return mMovieId; }
        }

        public RelayCommand LoadMovieCommand
        {
            get { return mLoadMovieCommand; }
        }

        public MovieInfoViewModel Context { get; set; }
    }
}
