using IncomeExpensesTable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDebtService
    {
        void AddDebt(Debt debt);
        IEnumerable<Debt> GetAllDebts();
        Debt GetDebtById(int debtId);
        void UpdateDebt(Debt debt);
        void DeleteDebt(int debtId);
    }

}

