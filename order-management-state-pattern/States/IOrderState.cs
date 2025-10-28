using OrderManagement.Models;

namespace OrderManagement.States
{
    // A interface State, que define as ações para todos os estados concretos.
    public interface IOrderState
    {
        void Pay(Order order);
        void Ship(Order order);
        void Deliver(Order order);
        void Cancel(Order order);
    }
}