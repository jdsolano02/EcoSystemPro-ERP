using System.ComponentModel.DataAnnotations;

namespace EcoSystemPro.Domain.Entities
{
    public class SaleDetail
    {
        [Key]
        public Guid Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        // unit price at the time of sale
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal UnitPrice { get; set; }

        // Subtotal
        public decimal SubTotal => Quantity * UnitPrice;

        // which sale this detail belongs to
        public Guid SaleId { get; set; }
        public virtual Sale? Sale { get; set; }

        // what product was sold in this detail
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}