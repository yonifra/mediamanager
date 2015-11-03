using System;
using System.Windows;

namespace MediaManager.Controls
{
  /// <summary>
  /// Interaction logic for YouTubeViewer.xaml
  /// </summary>
  public partial class YouTubeViewer
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
