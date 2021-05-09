using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MiisFurttalApp.Models
{
    public class DataPack
    {
        [JsonProperty("Activitys")]
        public List<Activity> Activities { get; set; }
        [JsonProperty("Signs")]
        public List<WayPoint> WayPoints { get; set; }
    }
}
