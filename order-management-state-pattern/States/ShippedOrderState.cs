using OrderManagement.Models;

namespace OrderManagement.States
{
    public class ShippedOrderState : IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine($"FAIL: Order {order.OrderId} has already been paid and shipped.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine($"FAIL: Order {order.OrderId} has already been shipped.");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine($"SUCCESS: Order {order.OrderId} has been delivered.");
            // Transição para o estado final: Entregue
            order.CurrentState = new DeliveredOrderState();
        }

        public void Cancel(Order order)
        {
            Console.WriteLine($"FAIL: Cannot cancel an order ({order.OrderId}) that has already been shipped.");
        }
    }
}