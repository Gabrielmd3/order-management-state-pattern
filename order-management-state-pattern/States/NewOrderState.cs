using OrderManagement.Models;

namespace OrderManagement.States
{
    public class NewOrderState : IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine($"SUCCESS: Payment for order {order.OrderId} confirmed.");
            // Transição para o próximo estado: Pago
            order.CurrentState = new PaidOrderState();
        }

        public void Ship(Order order)
        {
            Console.WriteLine($"FAIL: Cannot ship an order ({order.OrderId}) that has not been paid.");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine($"FAIL: Cannot deliver an order ({order.OrderId}) that has not been paid.");
        }

        public void Cancel(Order order)
        {
            Console.WriteLine($"SUCCESS: Order {order.OrderId} has been canceled.");
            // Transição para o estado final: Cancelado
            order.CurrentState = new CanceledOrderState();
        }
    }
}