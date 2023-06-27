using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMassTransit.Model;

namespace RabbitMassTransit.Repository.Interfaces
{
    public interface IOrderRepository
    {
        Task<string> CreatesOrder(OrderModel order);
    }
}