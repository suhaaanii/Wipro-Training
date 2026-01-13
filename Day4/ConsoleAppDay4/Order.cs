using System;

namespace OrderSystem
{
    public class Order : IPayment
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public Location ShippingLocation { get; set; }

        private IPayment paymentMethod;

        public Order(int orderId, Location location, IPayment payment)
        {
            OrderId = orderId;
            ShippingLocation = location;
            Status = OrderStatus.Pending;
            paymentMethod = payment;
        }

        public void ProcessPayment(double amount)
        {
            paymentMethod.ProcessPayment(amount);
            Status = OrderStatus.Processing;
        }

        public void RefundPayment(double amount)
        {
            paymentMethod.RefundPayment(amount);
            Status = OrderStatus.Cancelled;
        }

        public bool MakePayment(double amount)
        {
            return paymentMethod.MakePayment(amount);
        }

        public void ShowOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Location: {ShippingLocation.Latitude}, {ShippingLocation.Longitude}");
        }
    }
}
