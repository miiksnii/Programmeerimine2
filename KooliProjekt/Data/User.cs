using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class User
    {
        public ulong Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? Name { get; set; } // Name of the user

        public long UserId { get; set; } // Reference ID for the user
    }


}
