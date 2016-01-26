using System;
using System.Collections.Generic;

namespace _04_InsecureDirectObjectReference.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string Username { get; set; }

        public virtual IList<AccountTransaction> Transactions { get; set; }
        public ApplicationUser  User { get; set; }

        public Guid AccountId { get; set; }
    }
}