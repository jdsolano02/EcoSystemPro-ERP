using System;
using System.ComponentModel.DataAnnotations;


namespace EcoSystemPro.Domain.Entities
{
    public class Supplier
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The supplier name is required")]
        public required string Name { get; set; }


        [Required(ErrorMessage = "the supplier e-mail is required")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "the supplier phoneNumber is required")]
        public required string PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // each supplier can have many products
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}