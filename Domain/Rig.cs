using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Rig
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(5)]
        public string RigPrefix { get; set; }

        [StringLength(10)]
        public string shipBSEEId { get; set; }

        [Required]
        [StringLength(10)]
        public string shipId { get; set; }

        [Required]
        [StringLength(10)]
        public string shipMMSI { get; set; }

        [Required]
        [StringLength(10)]
        public string shipIMO { get; set; }

        //  Binding Contractors
        public RigContractor Contractor { get; set; }
        public Guid ContractorId { get; set; }
    }
}