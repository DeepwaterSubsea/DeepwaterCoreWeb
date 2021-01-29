using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class RigOperator
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}