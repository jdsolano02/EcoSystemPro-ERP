using System;
using System.ComponentModel.DataAnnotations;


namespace EcoSystemPro.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Product name is required")]
        public required string Name { get; set; }

        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "the price must be more than 0")]
        public required decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "the stock can not be negative")]
        public int Stock { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // each product belongs to one supplier
        // each supplier can have many products

        public Guid SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}