using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Project
    {
        public ulong Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? Name { get; set; } // Name of the project

        [Required]
        [StringLength(255)]
        public string? Deadline { get; set; } // Deadline of the project

        [Required]
        [StringLength(255)]
        public string? StartDate { get; set; } // Start date of the project

        [Required]
        [StringLength(255)]
        public string? EstimatedTimeSpent { get; set; } // Estimated time to complete the project

        [Required]
        [StringLength(255)]
        public string? Description { get; set; } // Description of the project

        public bool IsCompleted { get; set; } // Indicates if the project is completed

        public ulong TaskId { get; set; } // Reference to the task

        public long ResponsibleId { get; set; } // ID of the responsible person
    }


}
