﻿
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        // Navigation property for relationships
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
