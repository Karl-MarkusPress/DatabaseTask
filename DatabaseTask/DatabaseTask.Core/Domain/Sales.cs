
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Sale
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime SaleDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        // Foreign keys for relationships
        public Guid EmployeeId { get; set; }
        public Guid ProductId { get; set; }

        // Navigation properties for relationships
        public Employee Employee { get; set; }
        public Product Product { get; set; }
    }
}
