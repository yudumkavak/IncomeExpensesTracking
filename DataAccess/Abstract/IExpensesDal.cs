using GelirGiderTablosu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IExpensesDal
    {
        void AddExpenses(Expenses expenses);
        List<Expenses> GetAllExpenses();
        Expenses GetExpensesById(int expensesId);
        void UpdateExpenses(Expenses expenses);
        void DeleteExpenses(int expensesId);
    }
}
