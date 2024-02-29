using DataAccess.Abstract;
using IncomeExpensesTable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class DebtDal : IDebtDal
    {
        public void AddDebt(Debt debt)
        {
            // Veritabanına borç ekleme işlemi
            throw new NotImplementedException();
        }

        public IEnumerable<Debt> GetAllDebts()
        {
            // Tüm borçları veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public Debt GetDebtById(int debtId)
        {
            // Belirli bir borcu veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public void UpdateDebt(Debt debt)
        {
            // Borç güncelleme işlemi
            throw new NotImplementedException();
        }

        public void DeleteDebt(int debtId)
        {
            // Borç silme işlemi
            throw new NotImplementedException();
        }

        List<Debt> IDebtDal.GetAllDebts()
        {
            throw new NotImplementedException();
        }
    }
}
