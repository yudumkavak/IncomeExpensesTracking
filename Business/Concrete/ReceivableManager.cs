// ReceivableManager.cs

using GelirGiderTablosu.Entities;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using IncomeExpensesTable.Entities;

namespace IncomeExpensesTable.Business
{
    public class ReceivableManager : IReceivableService
    {
        private readonly IReceivableDal _receivableRepository;

        public ReceivableManager(IReceivableDal receivableRepository)
        {
            _receivableRepository = receivableRepository;
        }

        public void AddReceivable(Receivable receivable)
        {
            _receivableRepository.AddReceivable(receivable);
        }

        public IEnumerable<Receivable> GetAllReceivables()
        {
            return _receivableRepository.GetAllReceivables();
        }

        public Receivable GetReceivableById(int receivableId)
        {
            return _receivableRepository.GetReceivableById(receivableId);
        }

        public void UpdateReceivable(Receivable receivable)
        {
            _receivableRepository.UpdateReceivable(receivable);
        }

        public void DeleteReceivable(int receivableId)
        {
            _receivableRepository.DeleteReceivable(receivableId);
        }


    }
}