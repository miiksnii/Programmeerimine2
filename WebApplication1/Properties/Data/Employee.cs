using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Properties.Data
{
    public class Employee
    {
        [Required]
        public int Id { get; set; } // Employee ID

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Employee Name

        [Required]
        [StringLength(100)]
        public string Profession { get; set; } // Profession/Role of the employee

        [Required]
        public int ProjectId { get; set; } // Project ID that the employee is working on
    }
}
