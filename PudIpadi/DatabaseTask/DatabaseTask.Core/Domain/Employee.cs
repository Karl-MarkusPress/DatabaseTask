
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        // Navigation property for relationships
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

        public ICollection<Customer> Customers { get; set; } 
    }
}
