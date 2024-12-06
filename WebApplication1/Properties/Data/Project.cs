using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Properties.Data
{
    public class Project
    {

        public Project()
        {
            Name = "Project";
            TotalWorkingHours = 0;
            Description = string.Empty;
            DueEnd = DateTime.Now.AddMonths(1);
        }
        [Required]
        public int Id { get; set; } 

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, 10000)]
        public double TotalWorkingHours { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime? DueEnd { get; set; }
    }
}
