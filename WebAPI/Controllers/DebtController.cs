
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Abstract;
using IncomeExpensesTable.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DebtController : ControllerBase
    {
        private readonly IDebtService _debtService;

        public DebtController(IDebtService debtService)
        {
            _debtService = debtService;
        }

        [HttpGet]
        public IActionResult GetAllDebts()
        {
            var debts = _debtService.GetAllDebts();
            return Ok(debts);
        }

        [HttpGet("{id}")]
        public IActionResult GetDebtById(int id)
        {
            var debt = _debtService.GetDebtById(id);
            if (debt == null)
            {
                return NotFound();
            }
            return Ok(debt);
        }

        [HttpPost]
        public IActionResult AddDebt(Debt debt)
        {
            _debtService.AddDebt(debt);
            return CreatedAtAction(nameof(GetDebtById), new { id = debt.DebtId }, debt);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDebt(int id, Debt debt)
        {
            if (id != debt.DebtId)
            {
                return BadRequest();
            }
            _debtService.UpdateDebt(debt);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDebt(int id)
        {
            var existingDebt = _debtService.GetDebtById(id);
            if (existingDebt == null)
            {
                return NotFound();
            }
            _debtService.DeleteDebt(id);
            return NoContent();
        }
    }
}