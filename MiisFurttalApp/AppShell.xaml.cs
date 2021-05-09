using MiisFurttalApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MiisFurttalApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));

            Routing.RegisterRoute(nameof(RoutesPage), typeof(RoutesPage));

            Routing.RegisterRoute(nameof(WebPage), typeof(WebPage));
        }

    }
}
