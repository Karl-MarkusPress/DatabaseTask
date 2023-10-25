
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class PurchaseHistory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        
        public Guid CustomerId { get; set; }

        
        public Customer Customer { get; set; }
    }
}
