using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Models
{
    public class Account
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public List<Wallet> Wallets { get; set; }
    }
}
