using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class StatusInformation
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Type { get; set; }

        [Required]
        public string Name { get; set; }
    }
}