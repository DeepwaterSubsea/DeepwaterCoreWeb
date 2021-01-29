using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class RigAsset
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string SerialNumber { get; set; }
    }
}