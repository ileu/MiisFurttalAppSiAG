using System;
using System.Collections.Generic;
using System.Text;

namespace MiisFurttalApp.Models
{
    public class Track
    {
        public bool Visibile { get; set; }
        public Item Name { get; set; }
        public Item Describtion { get; set; }
        public string Url { get; set; }
        public string Sport { get; set; }
        public string Level { get; set; }
        public string Time { get; set; }
        public float Length { get; set; }
        public string Updown { get; set; }

    }
}
