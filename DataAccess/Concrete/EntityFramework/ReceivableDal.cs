using DataAccess.Abstract;
using IncomeExpensesTable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReceivableDal : IReceivableDal
    {
        public void AddReceivable(Receivable receivable)
        {
            // Veritabanına alacak ekleme işlemi
            throw new NotImplementedException();
        }

        public IEnumerable<Receivable> GetAllReceivables()
        {
            // Tüm alacakları veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public Receivable GetReceivableById(int receivableId)
        {
            // Belirli bir alacağı veritabanından alma işlemi
            throw new NotImplementedException();
        }

        public void UpdateReceivable(Receivable receivable)
        {
            // Alacak güncelleme işlemi
            throw new NotImplementedException();
        }

        public void DeleteReceivable(int receivableId)
        {
            // Alacak silme işlemi
            throw new NotImplementedException();
        }

        List<Receivable> IReceivableDal.GetAllReceivables()
        {
            throw new NotImplementedException();
        }
    }
}
