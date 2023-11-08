
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
   
        [Required]
        public DateTime SaleDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int TotalAmount { get; set; }


        // Navigation properties for relationships

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
