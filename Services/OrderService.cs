using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyOrder.Models;
using BuyOrder.Data;

namespace BuyOrder.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Order> GetOrders()
        {
            var order = _context.Orders.ToList();
            return order;
        }
    }
}