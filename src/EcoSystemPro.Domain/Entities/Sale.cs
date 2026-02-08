using System.ComponentModel.DataAnnotations;

namespace EcoSystemPro.Domain.Entities
{
    public class Sale
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Total { get; set; }


        // user that made the sale
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }

        // sale details for the products sold in this sale
        public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
    }
}