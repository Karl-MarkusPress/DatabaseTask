﻿
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        
        public PurchaseHistory PurchaseHistory { get; set; }
    }
}
