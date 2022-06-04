using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBike.Models
{
    public class Bike
    {
        public int ID { get; set; }
        public string ModelName { get; set; }
        public string CompanyName { get; set; }
        public string BikeType { get; set; }
        public int EngineCC { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfLaunch { get; set; }
    }
}