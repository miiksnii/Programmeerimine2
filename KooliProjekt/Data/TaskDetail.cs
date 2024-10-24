using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class TaskDetail
    {
        public ulong Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? TaskName { get; set; } // Name of the task

        [Required]
        [StringLength(255)]
        public string? TimeSpent { get; set; } // Time spent on the task

        [Required]
        [StringLength(255)]
        public string? ActivityDescription { get; set; } // Description of the activity

        [Required]
        [StringLength(255)]
        public string? Deadline { get; set; } // Deadline for the task

        [Required]
        public long HoursWorked { get; set; } // Hours worked on the task

        [Required]
        [StringLength(255)]
        public string? Executor { get; set; } // Executor of the task

        [Required]
        [StringLength(255)]
        public string? FileLocation { get; set; } // Location of the file
    }

}
