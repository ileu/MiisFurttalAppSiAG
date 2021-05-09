using MiisFurttalApp.Models;
using MiisFurttalApp.Services;
using MiisFurttalApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace MiisFurttalApp.ViewModels
{
    
    class RouteViewModel : ObservableObject
    {
        public ObservableRangeCollection<Activity> Activities { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public Command NavToWebCommand { get; }

        string title = string.Empty;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
            

        }

        bool isBusy;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (SetProperty(ref isBusy, value))
                    IsNotBusy = !isBusy;
            }
        }

        bool isNotBusy = true;

        public bool IsNotBusy
        {
            get => isNotBusy;
            set
            {
                if (SetProperty(ref isNotBusy, value))
                    IsBusy = !isNotBusy;
            }
        }


        public RouteViewModel()
        {
            Title = "Route Viewer";
            Activities = new ObservableRangeCollection<Activity>();

            RefreshCommand = new AsyncCommand(Refresh);
            NavToWebCommand = new Command<Activity>(NavToWeb);
        }

        async void NavToWeb(Activity activity)
        {
            if (activity == null)
                return;


            var root = $"{nameof(WebPage)}?Url=https://misfurttal.si-cube.ch";

            await Shell.Current.GoToAsync(root);
        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            Activities.Clear();

            var activities = await WebService.GetData();

            Activities.AddRange(activities.Activities);

            IsBusy = false;
        }
    }
}
