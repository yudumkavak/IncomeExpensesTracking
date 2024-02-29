using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTablosu.Entities
{
    public class Income:BaseEntity<int>    //gelir
    {
        public int IncomeId { get; set; } // Gelirin benzersiz kimliği
        public decimal IncomeAmount { get; set; } // Gelir miktarı (ondalık sayı olarak düşünülmeli)
        public DateTime IncomeDate { get; set; } // Gelir tarihi
        public string Description { get; set; } // Gelir açıklaması

    }
}
