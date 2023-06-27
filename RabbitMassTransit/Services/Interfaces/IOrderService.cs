using RabbitMassTransit.Model;

namespace RabbitMassTransit.Services.Interfaces
{
    public interface IOrderService
    {
        Task<string> CreatesOrder(OrderModel order);
    }
}