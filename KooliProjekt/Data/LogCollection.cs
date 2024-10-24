using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class LogCollection
    {
        public ulong Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? LogName { get; set; } // Name of the log

        [Required]
        [StringLength(255)]
        public string? Date { get; set; } // Date of the log entry

        [Required]
        [StringLength(255)]
        public string? TimeSpent { get; set; } // Time spent on the activity

        [Required]
        [StringLength(255)]
        public string? Executor { get; set; } // Executor of the activity

        [Required]
        [StringLength(255)]
        public string? ActivityDescription { get; set; } // Description of the activity
    }


}
