// ExpensesController.cs

using GelirGiderTablosu.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        [HttpGet]
        public IActionResult GetAllExpenses()
        {
            var expenses = _expensesService.GetAllExpenses();
            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public IActionResult GetExpenseById(int id)
        {
            var expense = _expensesService.GetExpensesById(id);
            if (expense == null)
            {
                return NotFound();
            }
            return Ok(expense);
        }

        [HttpPost]
        public IActionResult AddExpense([FromBody] Expenses expense)
        {
            _expensesService.AddExpenses(expense);
            return CreatedAtAction(nameof(GetExpenseById), new { id = expense.ExpensesId }, expense);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExpense(int id, [FromBody] Expenses expense)
        {
            if (id != expense.ExpensesId)
            {
                return BadRequest();
            }
            _expensesService.UpdateExpenses(expense);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExpense(int id)
        {
            var existingExpense = _expensesService.GetExpensesById(id);
            if (existingExpense == null)
            {
                return NotFound();
            }
            _expensesService.DeleteExpenses(id);
            return NoContent();
        }
    }
}