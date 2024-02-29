using IncomeExpensesTable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IReceivableDal
    {
        void AddReceivable(Receivable receivable);
        List<Receivable> GetAllReceivables();
        Receivable GetReceivableById(int receivableId);
        void UpdateReceivable(Receivable receivable);
        void DeleteReceivable(int receivableId);
    }
}
