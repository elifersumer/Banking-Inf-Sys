using System.Data.Entity;

namespace Staj_Projesi
{
    public class BankContext:DbContext
    {
        public DbSet<Customer> CUSTOMER { get; set; }
        public DbSet<Banker> BANKER { get; set; }
        public DbSet<CreditCard> CREDITCARD { get; set; }
        public DbSet<Account> ACCOUNT { get; set; }
    }
}