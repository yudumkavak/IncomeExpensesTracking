using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpensesTable.Entities
{
    public class Debt : BaseEntity<int> // BaseEntity<int> diyerek TId türünün int olduğunu belirtiyoruz
    {
        public int DebtId { get; set; } // Borcun benzersiz kimliği
        public decimal DebtAmount { get; set; } // Borç miktarı (ondalık sayı olarak düşünülmeli)
        public DateTime DebtDate { get; set; } // Borç tarihi
        public string Description { get; set; } // Borç açıklaması
        public string DebtorName { get; set; } // Borçlunun adı

    }
}
