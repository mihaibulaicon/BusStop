using System;
using NServiceBus;
using Contracts;
namespace Backend
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public void Handle(PlaceOrder message)
        {
            Console.WriteLine("Order received " + message.OrderId);
        }
    }
}
