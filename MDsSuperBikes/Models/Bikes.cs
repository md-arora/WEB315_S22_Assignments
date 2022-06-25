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
        public string Torque { get; set; }
        public int EngineCC { get; set; }
        public int TopSpeed { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfLaunch { get; set; }
    }
}