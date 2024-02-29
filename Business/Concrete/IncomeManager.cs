// IncomeManager.cs

using GelirGiderTablosu.Entities;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;

namespace IncomeExpensesTable.Business
{
    public class IncomeManager : IIncomeService
    {
        private readonly IIncomeDal _incomeRepository;

        public IncomeManager(IIncomeDal incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }

        public void AddIncome(Income income)
        {
            _incomeRepository.AddIncome(income);
        }

        public IEnumerable<Income> GetAllIncomes()
        {
            return _incomeRepository.GetAllIncomes();
        }

        public Income GetIncomeById(int incomeId)
        {
            return _incomeRepository.GetIncomeById(incomeId);
        }

        public void UpdateIncome(Income income)
        {
            _incomeRepository.UpdateIncome(income);
        }

        public void DeleteIncome(int incomeId)
        {
            _incomeRepository.DeleteIncome(incomeId);
        }
    }
}