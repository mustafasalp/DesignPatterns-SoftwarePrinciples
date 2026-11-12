using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BaseConverter;
using TemplateMethod.Models;

namespace TemplateMethod.ConcreteClasses
{
    public class CryptoPayment : PaymentProcessor
    {
        public string WalletAddress { get; set; }
        public decimal NetworkGasFee { get; set; } = 5.0m; // Örn: 5 USDT ağ ücreti

        public CryptoPayment(string walletAddress)
        {
            WalletAddress = walletAddress;
        }

        protected override bool ValidateOrder(Order order)
        {
            // Temel kontrole ek olarak cüzdan adresi formatı kontrolü
            return base.ValidateOrder(order) && !string.IsNullOrWhiteSpace(WalletAddress);
        }

        protected override decimal CalculateTotal(Order order)
        {
            return base.CalculateTotal(order) + NetworkGasFee;
        }

        protected override bool ProcessPayment(Order order)
        {
            Console.WriteLine($"{order.OrderTotal} USDT transferi {WalletAddress} adresinden blokzincirine iletildi.");
            return true;
        }

        protected override void GenerateReceipt(Order order)
        {
            Console.WriteLine($"[Kripto Dekontu] TxHash: 0x{Guid.NewGuid().ToString("N")} - Tutar: {order.OrderTotal}");
        }
    }
}
