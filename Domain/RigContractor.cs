using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class RigContractor
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}