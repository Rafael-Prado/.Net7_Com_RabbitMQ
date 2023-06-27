using RabbitMassTransit.Model;
using RabbitMassTransit.Repository.Interfaces;
using RabbitMassTransit.Services.Interfaces;

namespace RabbitMassTransit.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<string> CreatesOrder(OrderModel order)
        {
           return await _orderRepository.CreatesOrder(order);
        }
    }
}