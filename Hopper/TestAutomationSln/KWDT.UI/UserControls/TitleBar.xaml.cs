using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        public delegate void TitleBarHomeEventHandler(object sender, TitleBarHomeEventArgs e);

        // Register the routed event
        public static readonly RoutedEvent TitleBarHomeEvent =
            EventManager.RegisterRoutedEvent("TitleBarHome", RoutingStrategy.Bubble,
            typeof(TitleBarHomeEventHandler), typeof(Home));

        // .NET wrapper
        public event TitleBarHomeEventHandler TitleBarHome
        {
            add { AddHandler(TitleBarHomeEvent, value); }
            remove { RemoveHandler(TitleBarHomeEvent, value); }
        }

        public delegate void TitleBarBackEventHandler(object sender, TitleBarBackEventArgs e);

        // Register the routed event
        public static readonly RoutedEvent TitleBarBackEvent =
            EventManager.RegisterRoutedEvent("TitleBarBack", RoutingStrategy.Bubble,
            typeof(TitleBarBackEventHandler), typeof(Home));

        // .NET wrapper
        public event TitleBarBackEventHandler TitleBarBack
        {
            add { AddHandler(TitleBarBackEvent, value); }
            remove { RemoveHandler(TitleBarBackEvent, value); }
        }

        private void BtnHome_OnClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new TitleBarHomeEventArgs() { RoutedEvent = TitleBarHomeEvent });
        }

        private void BtnBack_OnClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent( new TitleBarBackEventArgs() { RoutedEvent = TitleBarBackEvent});
        }

        public void UpdateTitle(string newTitle)
        {
            lblTitle.Content = newTitle;
        }
    }
}
