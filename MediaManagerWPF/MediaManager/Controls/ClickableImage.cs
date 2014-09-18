using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MediaManager.Controls
{
    /// <summary>
    /// Custom image.
    /// </summary>
    public class ClickableImage : Image
    {
        /// <summary>
        /// The mouse left button double click event
        /// </summary>
        public static readonly RoutedEvent MouseLeftButtonDoubleClick =
            EventManager.RegisterRoutedEvent(
                "MouseLeftButtonDoubleClick",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(ClickableImage));

        /// <summary>
        /// Occurs when [mouse left button double click event handler].
        /// </summary>
        public event RoutedEventHandler MouseLeftButtonDoubleClickEvent
        {
            add
            {
                AddHandler(MouseLeftButtonDoubleClick, value);
            }
            remove
            {
                RemoveHandler(MouseLeftButtonDoubleClick, value);
            }
        }

        /// <summary>
        /// Invoked when an unhandled <see cref="E:System.Windows.UIElement.MouseLeftButtonDown" /> 
        /// routed event is raised on this element. Implement this method to add class handling for 
        /// this event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.Windows.Input.MouseButtonEventArgs" /> that 
        /// contains the event data. The event data reports that the left mouse button was pressed.
        /// </param>
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            // Double-click
            if (e.ClickCount == 2)
            {
                RaiseEvent(new MouseLeftButtonDoubleClickEventArgs(
                    MouseLeftButtonDoubleClick, this));
            }
            base.OnMouseLeftButtonDown(e);
        }

        /// <summary>
        /// MouseLeftButtonDoubleClick EventArgs.
        /// </summary>
        public class MouseLeftButtonDoubleClickEventArgs : RoutedEventArgs
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="MouseLeftButtonDoubleClickEventArgs"/> 
            /// class.
            /// </summary>
            /// <param name="routedEvent">The routed event identifier for this instance of the 
            /// <see cref="T:System.Windows.RoutedEventArgs" /> class.</param>
            /// <param name="source">An alternate source that will be reported when the event is 
            /// handled. This pre-populates the
            /// <see cref="P:System.Windows.RoutedEventArgs.Source" /> property.</param>
            public MouseLeftButtonDoubleClickEventArgs(RoutedEvent routedEvent, object source)
                : base(routedEvent, source)
            {
            }
        }
    }
}
