using GelirGiderTablosu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIncomeService
    {
        void AddIncome(Income income);
        IEnumerable<Income> GetAllIncomes();
        Income GetIncomeById(int incomeId);
        void UpdateIncome(Income income);
        void DeleteIncome(int incomeId);
    }
}
