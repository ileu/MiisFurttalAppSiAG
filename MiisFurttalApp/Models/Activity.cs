using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MiisFurttalApp.Models
{
    public class Activity
    {
        [JsonProperty("ActivityId")]
        public int Id { get; set; }
        public Item Name { get; set; }
        public string Level { get; set; }
        public Item Description { get; set; }
        public string Sport { get; set; }
        public string Type { get; set; }
    }
}
