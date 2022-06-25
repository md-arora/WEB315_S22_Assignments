using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesBike.Models
{
    public class Bike
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        public string ModelName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string CompanyName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(60)]
        [Required]
        public string BikeType { get; set; }

        [StringLength(70, MinimumLength = 5)]
        [Required]
        public string Torque { get; set; }

        
        [Range(40, 2000)]
        [Required]
        public int EngineCC { get; set; }

        [Range(80, 350)]
        public int TopSpeed { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfLaunch { get; set; }
    }
}