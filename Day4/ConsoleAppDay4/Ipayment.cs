namespace OrderSystem
{
    public interface IPayment
    {
        void ProcessPayment(double amount);
        void RefundPayment(double amount);
        bool MakePayment(double amount);
    }
}
