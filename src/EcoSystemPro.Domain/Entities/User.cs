using System.ComponentModel.DataAnnotations;

namespace EcoSystemPro.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string Username { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        [Required]
        public required string Role { get; set; }

        public bool IsActive { get; set; } = true;

        // one user can have many sales
        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}