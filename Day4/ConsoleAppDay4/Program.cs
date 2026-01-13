using System;
using OrderSystem;

class Program
{
    static void Main()
    {
        Location loc = new Location(28.6139, 77.2090);

        IPayment payment = new CreditCardPayment();

        Order order = new Order(1001, loc, payment);

        order.MakePayment(2500);
        order.ProcessPayment(2500);
        order.ShowOrderDetails();

        Console.WriteLine();

        order.RefundPayment(2500);
        order.ShowOrderDetails();
    }
}
