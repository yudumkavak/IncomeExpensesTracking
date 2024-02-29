using GelirGiderTablosu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IIncomeDal
    {
        void AddIncome(Income income);
        List<Income> GetAllIncomes();
        Income GetIncomeById(int incomeId);
        void UpdateIncome(Income income);
        void DeleteIncome(int incomeId);
    }
}
