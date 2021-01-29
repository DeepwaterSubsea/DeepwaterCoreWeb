using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Well
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }
        public string OCSG { get; set; }
        public int Depth { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}