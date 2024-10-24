using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Task
    {
        public ulong Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? ExecutorIds { get; set; } // IDs of executors

        [Required]
        [StringLength(255)]
        public string? TeamName { get; set; }

        [Required]
        [StringLength(255)]
        public string? Description { get; set; } // Description of the task

        public ulong TaskId { get; set; } // Reference to the associated task

        public ulong LogId { get; set; } // Reference to the log
    }


}
