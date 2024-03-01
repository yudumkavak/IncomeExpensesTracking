using Microsoft.EntityFrameworkCore;
using IncomeExpensesTable.Entities;
using GelirGiderTablosu.Entities;

namespace IncomeExpensesTable.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Receivable> Receivables { get; set; }
        public DbSet<Debt> Debts { get; set; }

        // Ek olarak, aşağıdaki gibi bir metot ekleyerek DbContextOptionsBuilder nesnesine bağlantı dizesini ekleyebilirsiniz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=IncomeExpensesDB;Trusted_Connection=True;");
            }
        }
    }
}