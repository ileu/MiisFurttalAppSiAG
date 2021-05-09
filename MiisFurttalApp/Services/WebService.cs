using MiisFurttalApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MiisFurttalApp.Services
{
    public static class WebService
    {

        // Local debug base url android: "http://10.0.2.2:5000" ; localhost: "http://localhost:5000"

        static string BaseUrl = "https://furttal-app.si-cube.ch/api/FurttalApp/FurttalAppData/";

        static HttpClient client;

        static WebService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl)
            };
        }

        internal static async Task<IEnumerable<Event>> GetEvents()
        {
            var json = await client.GetStringAsync("GetPushNotifications");
            var data = JsonConvert.DeserializeObject<IEnumerable<Event>>(json);

            return data;
        }

        public static async Task<DataPack> GetData()
        {
            var json = await client.GetStringAsync("Routes");
            var data = JsonConvert.DeserializeObject<DataPack>(json);

            return data;
        }

        public static async Task<IEnumerable<Track>> GetTracks()
        {
            var json = await client.GetStringAsync("tracks");
            var data = JsonConvert.DeserializeObject<IEnumerable<Track>>(json);

            return data;
        }

        public static async Task<IEnumerable<Point>> GetPoints()
        {
            var json = await client.GetStringAsync("points");
            var data = JsonConvert.DeserializeObject<IEnumerable<Point>>(json);

            return data;
        }
    }
}
