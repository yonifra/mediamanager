using System.Windows;
using MahApps.Metro.Controls;
using MediaManager.ViewModel;

namespace MediaManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MovieInfoViewModel();
        }
    }
}
