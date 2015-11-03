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
        public static MovieInfoViewModel MovieInfoViewModel { get; private set; }

        public ViewModelLocator()
        {
            MovieInfoViewModel = new MovieInfoViewModel();
        }
    }
}