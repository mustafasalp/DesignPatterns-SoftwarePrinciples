using Strategy.Interface;

namespace Strategy.Strategies;

public class GarantiBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Processing payment through Garanti Bank...");
        return true;
    }
}
