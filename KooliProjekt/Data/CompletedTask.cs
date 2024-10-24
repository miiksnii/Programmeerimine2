using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class CompletedTask
    {
        public ulong Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? Name { get; set; } // Name of the completed task

        [Required]
        [StringLength(255)]
        public string? TeamName { get; set; }

        [Required]
        public long TotalHours { get; set; } // Total hours spent on the task
    }

}
