using MassTransit;
using RabbitMassTransit.Model;
using RabbitMassTransit.Repository.Interfaces;

namespace RabbitMassTransit.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IBus _bus;

        public OrderRepository(IBus bus)
        {
            _bus = bus;
        }
        public async Task<string> CreatesOrder(OrderModel order)
        {
            await _bus.Publish(order);  
            return order.ToString();
        }
    }
}