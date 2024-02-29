using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTablosu.Entities
{
    public class Expenses : BaseEntity<int>  // gider
    {
        public int ExpensesId { get; set; } // Giderin benzersiz kimliği
        public decimal ExpensesAmount { get; set; } // Gider miktarı (ondalık sayı olarak düşünülmeli)
        public DateTime ExpensesDate { get; set; } // Gider tarihi
        public string ExpensesDescription { get; set; } // Gider açıklaması
    }
}
