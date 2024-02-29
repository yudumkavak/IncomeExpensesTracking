// ExpensesManager.cs

using GelirGiderTablosu.Entities;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;

namespace IncomeExpensesTable.Business
{
    public class ExpensesManager : IExpensesService
    {
        private readonly IExpensesDal _expensesRepository;

        public ExpensesManager(IExpensesDal expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }

        public void AddExpenses(Expenses expenses)
        {
            _expensesRepository.AddExpenses(expenses);
        }

        public IEnumerable<Expenses> GetAllExpenses()
        {
            return _expensesRepository.GetAllExpenses();
        }

        public Expenses GetExpensesById(int expensesId)
        {
            return _expensesRepository.GetExpensesById(expensesId);
        }

        public void UpdateExpenses(Expenses expenses)
        {
            _expensesRepository.UpdateExpenses(expenses);
        }

        public void DeleteExpenses(int expensesId)
        {
            _expensesRepository.DeleteExpenses(expensesId);
        }
    }
}