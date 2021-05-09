using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MiisFurttalApp.Models
{
    public class WayPoint
    {
        public Item Name { get; set; }
        [JsonProperty("SignId")]
        public int Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public Item Description { get; set; }
    }
}
