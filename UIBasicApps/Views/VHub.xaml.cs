using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UIBasicApps.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace UIBasicApps.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VHub : Page
    {
        public VHub()
        {
            this.InitializeComponent();
            VMTitle vmtitle = new VMTitle();
            Items.DataContext = vmtitle;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            var appbar = sender as AppBarButton;

            if (appbar != null)
            {
                switch (appbar.Tag.ToString())
                {
                    case "Lv":
                        Frame.Navigate(typeof(VListView));
                        break;
                    case "Pv":
                        Frame.Navigate(typeof(VPivot));
                        break;
                    case "Hb":
                        Frame.Navigate(typeof(VHub));
                        break;
                    case "Fv":
                        Frame.Navigate(typeof(VFlipView));
                        break;
                    case "Gv":
                        Frame.Navigate(typeof(VMain));
                        break;
                }
            }

        }
    }
}
