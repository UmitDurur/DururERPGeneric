﻿using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class OrderStatusServices : IOrderStatusServices
    {
        public Task AddOrderStatusAsync(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }

        public Task<OrderStatus> GetOrderStatusByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderStatus>> GetOrderStatusesAsync()
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderStatus(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderStatus(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }

        public OrderStatus UpdateOrderStatus(OrderStatus orderStatusToUpdate, OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}
