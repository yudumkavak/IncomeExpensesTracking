using IncomeExpensesTable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDebtDal
    {
        void AddDebt(Debt debt);
        List<Debt> GetAllDebts();
        Debt GetDebtById(int debtId);
        void UpdateDebt(Debt debt);
        void DeleteDebt(int debtId);
    }

}
