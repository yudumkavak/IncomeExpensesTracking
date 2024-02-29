// IncomeController.cs

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GelirGiderTablosu.Entities;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _incomeService;

        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        [HttpGet]
        public IActionResult GetAllIncomes()
        {
            var incomes = _incomeService.GetAllIncomes();
            return Ok(incomes);
        }

        [HttpGet("{id}")]
        public IActionResult GetIncomeById(int id)
        {
            var income = _incomeService.GetIncomeById(id);
            if (income == null)
            {
                return NotFound();
            }
            return Ok(income);
        }

        [HttpPost]
        public IActionResult AddIncome(Income income)
        {
            _incomeService.AddIncome(income);
            return CreatedAtAction(nameof(GetIncomeById), new { id = income.IncomeId }, income);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateIncome(int id, Income income)
        {
            if (id != income.IncomeId)
            {
                return BadRequest();
            }
            _incomeService.UpdateIncome(income);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteIncome(int id)
        {
            var existingIncome = _incomeService.GetIncomeById(id);
            if (existingIncome == null)
            {
                return NotFound();
            }
            _incomeService.DeleteIncome(id);
            return NoContent();
        }
    }
}