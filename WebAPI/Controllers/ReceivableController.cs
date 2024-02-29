// ReceivableController.cs

using GelirGiderTablosu.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Abstract;
using IncomeExpensesTable.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceivableController : ControllerBase
    {
        private readonly IReceivableService _receivableService;

        public ReceivableController(IReceivableService receivableService)
        {
            _receivableService = receivableService;
        }

        [HttpGet]
        public IActionResult GetAllReceivables()
        {
            var receivables = _receivableService.GetAllReceivables();
            return Ok(receivables);
        }

        [HttpGet("{id}")]
        public IActionResult GetReceivableById(int id)
        {
            var receivable = _receivableService.GetReceivableById(id);
            if (receivable == null)
            {
                return NotFound();
            }
            return Ok(receivable);
        }

        [HttpPost]
        public IActionResult AddReceivable([FromBody] Receivable receivable)
        {
            _receivableService.AddReceivable(receivable);
            return CreatedAtAction(nameof(GetReceivableById), new { id = receivable.ReceivableId }, receivable);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateReceivable(int id, [FromBody] Receivable receivable)
        {
            if (id != receivable.ReceivableId)
            {
                return BadRequest();
            }
            _receivableService.UpdateReceivable(receivable);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReceivable(int id)
        {
            var existingReceivable = _receivableService.GetReceivableById(id);
            if (existingReceivable == null)
            {
                return NotFound();
            }
            _receivableService.DeleteReceivable(id);
            return NoContent();
        }
    }
}