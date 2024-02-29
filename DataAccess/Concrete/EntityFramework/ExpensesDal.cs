using DataAccess.Abstract;
using GelirGiderTablosu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ExpensesDal : IExpensesDal
    {
        public void AddExpenses(Expenses expenses)
        {
            // Veritabanına gider ekleme işlemi
            throw new NotImplementedException();
        }

        public IEnumerable<Expenses> GetAllExpenses()
        {
            // Tüm giderleri veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public Expenses GetExpensesById(int expensesId)
        {
            // Belirli bir gideri veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public void UpdateExpenses(Expenses expenses)
        {
            // Gider güncelleme işlemi
            throw new NotImplementedException();
        }

        public void DeleteExpenses(int expensesId)
        {
            // Gider silme işlemi
            throw new NotImplementedException();
        }

        List<Expenses> IExpensesDal.GetAllExpenses()
        {
            throw new NotImplementedException();
        }
    }
}
