namespace Strategy.Interface;

public interface IPaymentService
{
    bool Pay(PaymentOptions paymentOptions);
}
