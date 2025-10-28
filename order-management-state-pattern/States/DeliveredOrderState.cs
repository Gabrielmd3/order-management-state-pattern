using OrderManagement.Models;

namespace OrderManagement.States
{
    public class DeliveredOrderState : IOrderState
    {
        public void Pay(Order order) => Console.WriteLine($"INFO: Order {order.OrderId} is already delivered.");
        public void Ship(Order order) => Console.WriteLine($"INFO: Order {order.OrderId} is already delivered.");
        public void Deliver(Order order) => Console.WriteLine($"INFO: Order {order.OrderId} is already delivered.");
        public void Cancel(Order order) => Console.WriteLine($"FAIL: Cannot cancel an order ({order.OrderId}) that has already been delivered.");
    }
}