using DataAccess.Abstract;
using GelirGiderTablosu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class IncomeDal : IIncomeDal
    {
        public void AddIncome(Income income)
        {
            // Veritabanına gelir ekleme işlemi
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetAllIncomes()
        {
            // Tüm gelirleri veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public Income GetIncomeById(int incomeId)
        {
            // Belirli bir geliri veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public void UpdateIncome(Income income)
        {
            // Gelir güncelleme işlemi
            throw new NotImplementedException();
        }

        public void DeleteIncome(int incomeId)
        {
            // Gelir silme işlemi
            throw new NotImplementedException();
        }

        List<Income> IIncomeDal.GetAllIncomes()
        {
            throw new NotImplementedException();
        }
    }
}
