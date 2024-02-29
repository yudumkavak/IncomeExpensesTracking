using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class BaseEntity<TId>
{
    public TId Id { get; set; } // kimliği

    public decimal Amount { get; set; } // miktarı (ondalık sayı olarak düşünülmeli)

    public DateTime? Date { get; set; } // tarihi

    public string Description { get; set; } // açıklaması
}