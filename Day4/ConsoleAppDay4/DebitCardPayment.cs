using System;

namespace OrderSystem
{
    public class DebitCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing debit card payment of ₹{amount}");
        }

        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Refunding debit card payment of ₹{amount}");
        }

        public bool MakePayment(double amount)
        {
            Console.WriteLine("Debit card payment successful");
            return true;
        }
    }
}
