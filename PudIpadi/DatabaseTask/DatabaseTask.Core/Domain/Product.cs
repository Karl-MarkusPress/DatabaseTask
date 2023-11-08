
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }
        public Sale Sale { get; set; }
    }
}
