using System;
using TemplateMethod.BaseConverter;
using TemplateMethod.BaseConverter;
using TemplateMethod.ConcreteClasses;
using TemplateMethod.Enums;
using TemplateMethod.Models;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Id = 101,
                Name = "Laptop Sırt Çantası",
                IsValid = true,
                ProductCount = 2,
                ProductValue = 250m
            };

            Console.WriteLine("=== KREDİ KARTI İLE ÖDEME ===");
            var card = new CreditCard { Id = 1, IsActive = true, Balance = 1000m };
            PaymentProcessor cardProcessor = new CreditCardPayment(card);
            cardProcessor.HandlePayment(order);

            Console.WriteLine("\n=== KRİPTO İLE ÖDEME ===");
            PaymentProcessor cryptoProcessor = new CryptoPayment("0xAb5801a7D398351b8bE11C439e05C5B3259aeC9B");
            cryptoProcessor.HandlePayment(order);

            Console.WriteLine("\n=== HESAP CÜZDANI İLE ÖDEME ===");
            var account = new Account { Id = 1, IsActive = true , Wallets = new List<Wallet> { new Wallet { Id = 1, Currency = CurrencyEnum.USD, Balance = 1000m } } }; // Added wallet
            PaymentProcessor accountProcessor = new AccountWalletPayment(account);
            accountProcessor.HandlePayment(order);

            Console.ReadLine();
        }
    }
}
