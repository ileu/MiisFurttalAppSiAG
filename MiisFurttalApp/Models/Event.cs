using System;
using System.Collections.Generic;
using System.Text;

namespace MiisFurttalApp.Models
{
    public class Event
    {
        public Item Title { get; set; }
        public Item Description { get; set; }
        public List<string> Area { get; set; }
        public string Link { get; set; }
    }
}
