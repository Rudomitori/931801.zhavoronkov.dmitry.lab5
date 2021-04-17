using System;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        [Required]
        public DateTime BirthDate { get; set; } 

        public Gender Gender { get; set; }

    }
}
