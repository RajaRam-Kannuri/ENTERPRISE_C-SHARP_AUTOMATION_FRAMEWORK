using System.Windows;
using KWDT.UI.UserControls;

namespace KWDT.UI
{
    public class LoadChildEventArgs : RoutedEventArgs
    {
        public BaseUserControl childPage { get; set; }
    }

    public class CloseChildEventArgs : RoutedEventArgs
    {

    }

    public class ReturnHomeEventArgs : RoutedEventArgs
    {

    }

    public class EditorSaveEventArgs : RoutedEventArgs
    {

    }

    public class EditorSaveCopyEventArgs : RoutedEventArgs
    {

    }

    public class EditorDeleteEventArgs : RoutedEventArgs
    {

    }

    public class EditorExportEventArgs : RoutedEventArgs
    {

    }

    public class TitleBarHomeEventArgs : RoutedEventArgs
    {

    }

    public class TitleBarBackEventArgs : RoutedEventArgs
    {

    }
}
