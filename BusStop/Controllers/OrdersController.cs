using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contracts;
using NServiceBus;
namespace BusStop.Controllers
{
    public class OrdersController : ApiController
    {
        public Guid Get()
        {
            var order = new PlaceOrder()
            {
                OrderId = Guid.NewGuid(),
                CustomerId = Guid.NewGuid(),
                ProductId = Guid.NewGuid()
            };
            WebApiApplication.Bus.Send(order);
            return order.OrderId;
        }
    }
}
