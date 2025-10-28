using OrderManagement.Models;

namespace OrderManagement.States
{
    public class CanceledOrderState : IOrderState
    {
        public void Pay(Order order) => Console.WriteLine($"FAIL: A canceled order ({order.OrderId}) cannot be paid.");
        public void Ship(Order order) => Console.WriteLine($"FAIL: A canceled order ({order.OrderId}) cannot be shipped.");
        public void Deliver(Order order) => Console.WriteLine($"FAIL: A canceled order ({order.OrderId}) cannot be delivered.");
        public void Cancel(Order order) => Console.WriteLine($"INFO: Order {order.OrderId} is already canceled.");
    }
}