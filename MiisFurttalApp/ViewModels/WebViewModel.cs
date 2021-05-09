using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using MvvmHelpers;

namespace MiisFurttalApp.ViewModels
{
    [QueryProperty(nameof(Url), nameof(Url))]
    public class WebViewModel : BaseViewModel
    {
        string url;

        public string Url
        {
            get => url;
            set
            {
                url = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }
    }

}
