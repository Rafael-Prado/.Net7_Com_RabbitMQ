
using MassTransit;
using RabbitMassTransit.Model;

namespace RabbitMassTransit.Consumer
{
    public class OrderCreatedConsumer : IConsumer<OrderModel>
    {

        public Task Consume(ConsumeContext<OrderModel> context)
        {
            Console.WriteLine(context.Message);
            return Task.CompletedTask;
        }
    }
}