using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Enums;

namespace TemplateMethod.Models
{
    public class Wallet
    {
        public int Id { get; set; }

        public bool IsLocked { get; set; }

        public CurrencyEnum Currency { get; set; } // One of the enums

        public decimal Balance { get; set; }
    }
}
