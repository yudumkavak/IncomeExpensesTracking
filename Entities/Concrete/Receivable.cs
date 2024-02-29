using Core.Entities;
using System;

namespace IncomeExpensesTable.Entities
{
    public class Receivable : BaseEntity<int>
    {
        public int ReceivableId { get; set; }
        public decimal ReceivableAmount { get; set; }
        public DateTime ReceivableDate { get; set; }
        public string Description { get; set; }
    }
}