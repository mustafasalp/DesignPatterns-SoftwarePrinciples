using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BaseConverter;
using TemplateMethod.Enums;
using TemplateMethod.Models;

namespace TemplateMethod.ConcreteClasses
{
    public class AccountWalletPayment : PaymentProcessor
    {
        private readonly Account _account;


        public AccountWalletPayment(Account account)
        {
            _account = account;
        }

        protected override bool ProcessPayment(Order order)
        {
            Console.WriteLine("1 - TRY");
            Console.WriteLine("2 - USD");
            Console.WriteLine("3 - EUR");
            Console.Write("Ödeme yapmak istediğiniz para birimini seçin ?: ");
            
            CurrencyEnum currency = (CurrencyEnum)int.Parse(Console.ReadLine());

            Wallet wallet = _account.Wallets
                .FirstOrDefault(w => w.Currency == currency);

            if (wallet == null || wallet.Balance < order.OrderTotal)
                return false;

            wallet.Balance -= order.OrderTotal;
            return true;
        }
    }
}
