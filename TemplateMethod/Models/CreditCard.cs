using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Models
{
    public class CreditCard
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public decimal Balance { get; set; }


        // other props optional
    }
}
