using Microsoft.EntityFrameworkCore;
using IncomeExpensesTable.Entities;
using GelirGiderTablosu.Entities; // Entity sınıflarının namespace'i

namespace IncomeExpensesTable.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Income> Incomes { get; set; } // Gelir tablosu DbSet
        public DbSet<Expenses> Expenses { get; set; } // Gider tablosu DbSet
        public DbSet<Receivable> Receivables { get; set; } // Alacak tablosu DbSet
        public DbSet<Debt> Debts { get; set; } // Borç tablosu DbSet
    }
}