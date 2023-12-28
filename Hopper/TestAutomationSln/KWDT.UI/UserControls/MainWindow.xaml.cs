using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using KWDT.UI.Factories;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for KWDTMainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ChildPageFactory childPageFactory)
        {
            InitializeComponent();
            HomeControl.ChildPageFactory = childPageFactory;
        }

        private void LoadChild(object sender, LoadChildEventArgs e)
        {
            SubscribeToEvents(e.childPage);
            e.childPage.ChildPageFactory = HomeControl.ChildPageFactory;
            ShowEmIt.Children.OfType<UserControl>().Last().Visibility = Visibility.Collapsed;
            ShowEmIt.Children.Add(e.childPage);
        }

        private void CloseChild(object sender, CloseChildEventArgs e)
        {
            BaseUserControl childToClose = ShowEmIt.Children.OfType<BaseUserControl>().Last();
            UnsubscribeToEvents(childToClose);
            ShowEmIt.Children.Remove(childToClose);
            BaseUserControl childToShow = ShowEmIt.Children.OfType<BaseUserControl>().Last();
            childToShow.Visibility = Visibility.Visible;
        }

        private void ReturnHome(object sender, ReturnHomeEventArgs e)
        {
            while (ShowEmIt.Children.Count > 1)
            {
                BaseUserControl childToClose = ShowEmIt.Children.OfType<BaseUserControl>().Last();
                UnsubscribeToEvents(childToClose);
                ShowEmIt.Children.Remove(childToClose);
            }
            BaseUserControl childToShow = ShowEmIt.Children.OfType<BaseUserControl>().First();
            childToShow.Visibility = Visibility.Visible;
        }

        private void SubscribeToEvents(BaseUserControl childControl)
        {
            childControl.CloseChild += CloseChild;
            childControl.LoadChild += LoadChild;
            childControl.ReturnHome += ReturnHome;
        }

        private void UnsubscribeToEvents(BaseUserControl childControl)
        {
            childControl.CloseChild -= CloseChild;
            childControl.LoadChild -= LoadChild;
            childControl.ReturnHome -= ReturnHome;
        }
    }
}
