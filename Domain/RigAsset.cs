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

        //  Binding OEMs
        public RigOriginalEquipmentManufacturer OEM { get; set; }
        public Guid OEMId { get; set; }

        //  Binding Rigs
        public Rig Rig { get; set; }
        public Guid RigId { get; set; }
    }
}