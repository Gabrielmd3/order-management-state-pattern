using OrderManagement.Models;

namespace OrderManagement.States
{
    public class PaidOrderState : IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine($"FAIL: Order {order.OrderId} has already been paid.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine($"SUCCESS: Order {order.OrderId} has been shipped.");
            // Transição para o próximo estado: Enviado
            order.CurrentState = new ShippedOrderState();
        }

        public void Deliver(Order order)
        {
            Console.WriteLine($"FAIL: Cannot deliver an order ({order.OrderId}) that has not been shipped.");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine($"SUCCESS: Order {order.OrderId} has been canceled. A refund will be processed.");
            // Transição para o estado final: Cancelado
            order.CurrentState = new CanceledOrderState();
        }
    }
}