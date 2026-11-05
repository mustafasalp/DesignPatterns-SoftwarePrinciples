

var paymentOptions = new PaymentOptions
{
    CardNumber = "1234 5678 9012 3456",
    CardHolderName = "John Doe",
    ExpirationDate = "12/25",
    Cvv = "123",
    Amount = 100.00m
};

var paymentService = new PaymentService();

do
{
    Console.WriteLine("Ödeme yapılacak bankayı seçiniz(1-Garanti, 2-Akbank, 3-IsBank): ");
    var bank = int.Parse(Console.ReadLine());

    IPaymentService bankPaymentService = null;

    switch (bank)
    {
        case 1:
            bankPaymentService = new GarantiBankPaymentService();
            break;
        case 2:
            bankPaymentService = new AkbankPaymentService();
            break;
        case 3:
            bankPaymentService = new IsBankPaymentService();
            break;
        default:
            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            continue;
    }

    paymentService.SetPaymentService(bankPaymentService);
    paymentService.PayViaStrategy(paymentOptions);

} while (Console.ReadKey().Key != ConsoleKey.Escape);


public class PaymentService
{
    private IPaymentService _paymentService;
    public PaymentService()
    {
            
    }
    public PaymentService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }
            
    public void SetPaymentService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public bool PayViaStrategy(PaymentOptions paymentOptions)
    {
        return _paymentService.Pay(paymentOptions);
    }
}

// Strategies: The classes that actually implement the payment processing logic for different strategies.
public class GarantiBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Processing payment through Garanti Bank...");
        return true;
    }
}

public class AkbankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Processing payment through Akbank...");
        return true; 
    }
}

public class IsBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Processing payment through IsBank...");
        return true; 
    }
}

public interface IPaymentService
{
    bool Pay(PaymentOptions paymentOptions);
}

public class PaymentOptions
{
    public string CardNumber { get; set; }

    public string CardHolderName { get; set; }

    public string ExpirationDate { get; set; }

    public string Cvv { get; set; }

    public decimal Amount { get; set; }
}
