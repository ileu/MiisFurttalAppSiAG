using MvvmHelpers;
using Xamarin.Essentials;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;
using Map = Xamarin.Forms.Maps.Map;

namespace MiisFurttalApp.ViewModels
{
    class TrackerViewModel : BaseViewModel
    {


        public TrackerViewModel()
        {

        }

        public static async void DisplayCurrentLoc(Map map)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                Location location = await Geolocation.GetLocationAsync(request);
                if (location != null)
                {
                    Position userPosition = new Position(location.Latitude, location.Longitude);
                    map.MoveToRegion(MapSpan.FromCenterAndRadius(userPosition, Distance.FromKilometers(1)));
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }
        }
    }
}
