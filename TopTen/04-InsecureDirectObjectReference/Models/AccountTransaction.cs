using System;
using System.ComponentModel.DataAnnotations;

namespace _04_InsecureDirectObjectReference.Models
{
    public class AccountTransaction
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public Account Account { get; set; } 
    }
}