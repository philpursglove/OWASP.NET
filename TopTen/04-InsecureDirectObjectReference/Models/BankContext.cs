using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace _04_InsecureDirectObjectReference.Models
{
    public class BankContext : DbContext
    {
        public BankContext() :base("OWASP")
        {
            
        }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}