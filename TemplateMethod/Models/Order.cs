using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace TemplateMethod.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }  

        public bool IsValid { get; set; }

        public decimal ProductValue { get; set; }

        public int ProductCount { get; set; }

        public decimal OrderTotal { get; set; }
    }
}
