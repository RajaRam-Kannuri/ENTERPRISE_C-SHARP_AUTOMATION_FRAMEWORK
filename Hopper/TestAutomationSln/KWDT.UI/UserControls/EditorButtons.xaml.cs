using System.Windows;
using System.Windows.Controls;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for EditorButtons.xaml
    /// </summary>
    public partial class EditorButtons : UserControl
    {
        public delegate void EditorSaveEventHandler(object sender, EditorSaveEventArgs e);

        public static readonly RoutedEvent EditorSaveEvent = EventManager.RegisterRoutedEvent(
            "EditorSave",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(EditorButtons));

        public event RoutedEventHandler EditorSave
        {
            add { AddHandler(EditorSaveEvent, value); }
            remove { RemoveHandler(EditorSaveEvent, value); }
        }

        public delegate void EditorSaveCopyEventHandler(object sender, EditorSaveCopyEventArgs e);

        public static readonly RoutedEvent EditorSaveCopyEvent = EventManager.RegisterRoutedEvent(
            "EditorSaveCopy",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(EditorButtons));

        public event RoutedEventHandler EditorSaveCopy
        {
            add { AddHandler(EditorSaveCopyEvent, value); }
            remove { RemoveHandler(EditorSaveCopyEvent, value); }
        }

        public delegate void EditorDeleteEventHandler(object sender, EditorDeleteEventArgs e);

        public static readonly RoutedEvent EditorDeleteEvent = EventManager.RegisterRoutedEvent(
            "EditorDelete",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(EditorButtons));

        public event RoutedEventHandler EditorDelete
        {
            add { AddHandler(EditorDeleteEvent, value); }
            remove { RemoveHandler(EditorDeleteEvent, value); }
        }

        public delegate void EditorExportEventHandler(object sender, EditorExportEventArgs e);

        public static readonly RoutedEvent EditorExportEvent = EventManager.RegisterRoutedEvent(
            "EditorExport",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(EditorButtons));

        public event RoutedEventHandler EditorExport
        {
            add { AddHandler(EditorExportEvent, value); }
            remove { RemoveHandler(EditorExportEvent, value); }
        }

        public EditorButtons()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new EditorSaveEventArgs() { RoutedEvent = EditorSaveEvent });
        }

        private void saveCopy_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new EditorSaveCopyEventArgs() { RoutedEvent = EditorSaveCopyEvent });
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new EditorDeleteEventArgs() { RoutedEvent = EditorDeleteEvent });
        }

        private void export_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new EditorExportEventArgs() { RoutedEvent = EditorExportEvent });
        }
    }
}
