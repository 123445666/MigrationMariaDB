using Microsoft.EntityFrameworkCore;

namespace DemoMariaDB.Model
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> opts) : base(opts)
        {

        }

        public DbSet<OnlineAccount> OnlineAccounts { get; set; }
    }
}
