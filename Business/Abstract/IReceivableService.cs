using IncomeExpensesTable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReceivableService
    {
        void AddReceivable(Receivable receivable);
        IEnumerable<Receivable> GetAllReceivables();
        Receivable GetReceivableById(int receivableId);
        void UpdateReceivable(Receivable receivable);
        void DeleteReceivable(int receivableId);
    }
}
