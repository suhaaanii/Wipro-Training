using System;

namespace OrderSystem
{
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of ₹{amount}");
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Refunding credit card payment of ₹{amount}");
        }

        public bool MakePayment(double amount)
        {
            Console.WriteLine("Credit card payment successful");
            return true;
        }
    }
}
