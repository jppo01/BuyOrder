using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyOrder.Models;
using BuyOrder.Data;
using Microsoft.AspNetCore.Authorization;

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
        public Order GetOrderById(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.OrderId == id);
            return order;
  
        }

    }
}