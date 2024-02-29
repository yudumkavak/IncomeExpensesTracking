using GelirGiderTablosu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExpensesService
    {
        void AddExpenses(Expenses expenses);
        IEnumerable<Expenses> GetAllExpenses();
        Expenses GetExpensesById(int expensesId);
        void UpdateExpenses(Expenses expenses);
        void DeleteExpenses(int expensesId);
    }
}
