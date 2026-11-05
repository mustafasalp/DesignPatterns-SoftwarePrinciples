using Strategy.Interface;

namespace Strategy.Strategies;

public class AkbankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Processing payment through Akbank...");
        return true; 
    }
}
