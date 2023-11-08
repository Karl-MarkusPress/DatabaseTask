
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class PurchaseHistory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public int TotalAmount { get; set; }


        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
