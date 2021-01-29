using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class RigOriginalEquipmentManufacturer
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}