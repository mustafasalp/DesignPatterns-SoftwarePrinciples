using Strategy.Interface;

namespace Strategy.Strategies;

public class IsBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Processing payment through IsBank...");
        return true; 
    }
}
