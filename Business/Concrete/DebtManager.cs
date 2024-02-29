// DebtService.cs

using IncomeExpensesTable.Entities;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;

namespace IncomeExpensesTable.Business
{
    public class DebtManager : IDebtService
    {
        private readonly IDebtDal _debtRepository;

        public DebtManager(IDebtDal debtRepository)
        {
            _debtRepository = debtRepository;
        }

        public void AddDebt(Debt debt)
        {
            _debtRepository.AddDebt(debt);
        }

        public IEnumerable<Debt> GetAllDebts()
        {
            return _debtRepository.GetAllDebts();
        }

        public Debt GetDebtById(int debtId)
        {
            return _debtRepository.GetDebtById(debtId);
        }

        public void UpdateDebt(Debt debt)
        {
            _debtRepository.UpdateDebt(debt);
        }

        public void DeleteDebt(int debtId)
        {
            _debtRepository.DeleteDebt(debtId);
        }
    }
}