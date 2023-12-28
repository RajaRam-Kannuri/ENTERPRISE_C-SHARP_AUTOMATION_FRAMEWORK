using System;
using System.Windows;
using System.Windows.Controls;
using KWDT.UI.Factories;

namespace KWDT.UI.UserControls
{
    public abstract class BaseUserControl : UserControl
    {
        public ChildPageFactory ChildPageFactory { get; set; }

        public delegate void CloseChildEventHandler(object sender, CloseChildEventArgs e);

        // Register the routed event
        public static readonly RoutedEvent CloseChildEvent =
            EventManager.RegisterRoutedEvent("CloseChild", RoutingStrategy.Bubble,
            typeof(CloseChildEventHandler), typeof(Home));

        // .NET wrapper
        public event CloseChildEventHandler CloseChild
        {
            add { AddHandler(CloseChildEvent, value); }
            remove { RemoveHandler(CloseChildEvent, value); }
        }

        public delegate void ReturnHomeEventHandler(object sender, ReturnHomeEventArgs e);

        // Register the routed event
        public static readonly RoutedEvent ReturnHomeEvent =
            EventManager.RegisterRoutedEvent("ReturnHome", RoutingStrategy.Bubble,
            typeof(ReturnHomeEventHandler), typeof(Home));

        // .NET wrapper
        public event ReturnHomeEventHandler ReturnHome
        {
            add { AddHandler(ReturnHomeEvent, value); }
            remove { RemoveHandler(ReturnHomeEvent, value); }
        }

        public delegate void LoadChildEventHandler(object sender, LoadChildEventArgs e);

        // Register the routed event
        public static readonly RoutedEvent LoadChildEvent =
            EventManager.RegisterRoutedEvent("LoadChild", RoutingStrategy.Bubble,
            typeof(LoadChildEventHandler), typeof(Home));

        // .NET wrapper
        public event LoadChildEventHandler LoadChild
        {
            add { AddHandler(LoadChildEvent, value); }
            remove { RemoveHandler(LoadChildEvent, value); }
        }

        protected void LoadChildPage(BaseUserControl pageToLoad)
        {
            LoadChildEventArgs cba = new LoadChildEventArgs();
            cba.childPage = pageToLoad;
            cba.RoutedEvent = LoadChildEvent;
            RaiseEvent(cba);
        }

        protected void CloseChildPage()
        {
            RaiseEvent(new CloseChildEventArgs() { RoutedEvent = CloseChildEvent });
        }

        protected void TitleBar_OnTitleBarHome(object sender, TitleBarHomeEventArgs e)
        {
            MessageBoxResult result;

            if ((((KWDT.UI.UserControls.TitleBar)sender).lblTitle).ToString().Contains("Editor"))
            {
                result = MessageBox.Show("Are you sure you want to navigate away from this page? Any unsaved data will be lost.", "Proceed without saving", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

                if (result == MessageBoxResult.Yes)
                    RaiseEvent(new ReturnHomeEventArgs() { RoutedEvent = ReturnHomeEvent });
            }
            else
                RaiseEvent(new ReturnHomeEventArgs() { RoutedEvent = ReturnHomeEvent });
        }

        protected void TitleBar_OnTitleBarBack(object sender, TitleBarBackEventArgs e)
        {
            MessageBoxResult result;
			if ((((KWDT.UI.UserControls.TitleBar)sender).lblTitle).ToString().Contains("Editor"))
            {
                result = MessageBox.Show("Are you sure you want to navigate away from this page? Any unsaved data will be lost.", "Proceed without saving", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

                if (result == MessageBoxResult.Yes)
                    CloseChildPage();
            }
            else
                CloseChildPage();
        }

        protected void ConfirmSave()
        {
            MessageBoxResult result = MessageBox.Show("Item successfully saved!", "Save Item", MessageBoxButton.OK);
        }

        protected bool ConfirmDelete()
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            return (result == MessageBoxResult.Yes);
        }

        protected bool ConfirmMultipleDelete()
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete the selected items?", "Delete Items", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            return (result == MessageBoxResult.Yes);
        }
    }
}
