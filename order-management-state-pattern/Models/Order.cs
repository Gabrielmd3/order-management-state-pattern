using OrderManagement.States;

namespace OrderManagement.Models
{
    // A classe Context (Order) que mantém uma referência ao seu estado atual.
    public class Order
    {
        public int OrderId { get; }
        public IOrderState CurrentState { get; set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            // Um novo pedido sempre começa no estado "Novo".
            CurrentState = new NewOrderState();
            Console.WriteLine($"Order {OrderId} created. Initial State: {CurrentState.GetType().Name}");
        }

        public void Pay()
        {
            CurrentState.Pay(this);
        }

        public void Ship()
        {
            CurrentState.Ship(this);
        }

        public void Deliver()
        {
            CurrentState.Deliver(this);
        }

        public void Cancel()
        {
            CurrentState.Cancel(this);
        }
    }
}