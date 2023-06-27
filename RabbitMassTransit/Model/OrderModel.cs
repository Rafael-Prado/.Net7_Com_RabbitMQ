using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMassTransit.Model
{
    public class OrderModel
    {
        public OrderModel(int id, CustomerModel customerModel, DateTime createdAt)
        {
            Id=id;
            CustomerModel=customerModel;
            CreatedAt = createdAt;
        }
        public int Id { get; set; }
        public CustomerModel CustomerModel { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString(){
            return $"Order Id {Id}, Custumer name : {CustomerModel.FullName}, Created At: {CreatedAt:d}";
        }
    }
}