using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaManager.Controls
{
  /// <summary>
  /// Interaction logic for YouTubeViewer.xaml
  /// </summary>
  public partial class YouTubeViewer : UserControl
  {
    public YouTubeViewer()
    {
      InitializeComponent();
    }

    public Uri Source
    {
      get { return (Uri)GetValue(SourceProperty); }
      set { SetValue(SourceProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SourceProperty =  
        DependencyProperty.Register("Source", typeof(Uri), typeof(YouTubeViewer), new UIPropertyMetadata(SourceChanged));

    public static void SourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      ((YouTubeViewer)d).Browser.Source = (Uri)e.NewValue;
    }
  }
}
