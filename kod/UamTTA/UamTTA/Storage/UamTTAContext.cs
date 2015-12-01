using System.Configuration;
using System.Data.Entity;
using UamTTA.Model;

namespace UamTTA.Storage
{
    public class UamTTAContext : DbContext
    {
        public UamTTAContext()
            : this("UamTTAConnectionString")
        {
        }

        public UamTTAContext(string connectionStringName)
            : base(ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Budget> Budgets { get; set; }

        public DbSet<Transfer> Transfers { get; set; }

        public DbSet<BudgetTemplate> Templates { get; set; }
    }
}