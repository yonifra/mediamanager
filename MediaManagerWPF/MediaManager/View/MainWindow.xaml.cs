using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MediaManager.ViewModel;

namespace MediaManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MovieInfoViewModel();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // if user didn't press Enter, do nothing
            if (!e.Key.Equals(Key.Enter)) return;

            // execute the command, if it exists
            var cmd = GetTextBoxPressEnterCommand((TextBox)sender);
            cmd?.Execute(null);
        }

        // declare an attached dependency property
        public static ICommand GetTextBoxPressEnterCommand(TextBox obj)
        {
            return (ICommand)obj.GetValue(TextBoxPressEnterCommandProperty);
        }
        public static void SetTextBoxPressEnterCommand(TextBox obj, ICommand value)
        {
            obj.SetValue(TextBoxPressEnterCommandProperty, value);
        }
        public static readonly DependencyProperty TextBoxPressEnterCommandProperty =
            DependencyProperty.RegisterAttached("TextBoxPressEnterCommand", typeof(ICommand), typeof(MainWindow));
    }
}
