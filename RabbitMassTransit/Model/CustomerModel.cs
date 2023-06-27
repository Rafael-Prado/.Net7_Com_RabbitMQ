using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMassTransit.Model
{
    public class CustomerModel
    {
        public CustomerModel(int id, string fullName, string email)
        {
            Id = id;
            FullName = fullName;
            Email = email;            
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public  string Email { get; set; }
    }
}