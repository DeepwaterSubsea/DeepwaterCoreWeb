using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class RigWellOperatorRecord
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(7)]
        public string BOP { get; set; }

        [Required]
        [StringLength(7)]
        public string LMRP { get; set; }

        public DateTime LatchDate { get; set; }
        public DateTime? UnlatchDate { get; set; }

        //  Bind Rig
        public Rig Rig { get; set; }
        public Guid RigId { get; set; }

        //  Bind Well
        public Well Well { get; set; }
        public Guid WellId { get; set; }

        //  Bind Operator
        public RigOperator Operator { get; set; }
        public Guid OperatorId { get; set; }
    }
}