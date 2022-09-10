using System;
using System.ComponentModel.DataAnnotations;

namespace Park_Lookup.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
    }
}