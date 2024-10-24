using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Employee
    {
        public ulong Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? TeamName { get; set; } // Name of the team

        [Required]
        [StringLength(255)]
        public string? Area { get; set; } // Area of responsibility

        [Required]
        [StringLength(255)]
        public string? FullName { get; set; } // Full name of the employee

        public long? UserId { get; set; } // Reference ID for the user, can be null
    }



}
