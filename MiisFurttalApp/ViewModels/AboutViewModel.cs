using MiisFurttalApp.Models;
using MiisFurttalApp.Services;
using MiisFurttalApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace MiisFurttalApp.ViewModels
{
    class AboutViewModel
    {

        public ObservableRangeCollection<Event> Events { get; set; }

        public AsyncCommand OpenWebCommand { get; set; }

        public AboutViewModel()
        {
            Events = new ObservableRangeCollection<Event>();

            OpenWebCommand = new AsyncCommand(OpenWeb);
        }

        public async Task LoadEvents()
        {
            Events.Clear();
            var events = await WebService.GetEvents();

            Events.AddRange(events);
        }

        async Task OpenWeb()
        {
            var route = $"{nameof(WebPage)}";

            await AppShell.Current.GoToAsync(route);
        }

    }
}
