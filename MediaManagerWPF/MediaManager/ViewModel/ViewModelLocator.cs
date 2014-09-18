using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using MediaManager.Model;

namespace MediaManager.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        private static MovieInfoViewModel _main;

        public static MovieInfoViewModel MovieInfoViewModel
        {
            get
            {
                return _main;
            }
        }

        public ViewModelLocator()
        {
            _main = new MovieInfoViewModel();
        }
    }
}