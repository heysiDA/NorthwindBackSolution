using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {
        IEnumerable<OrderList> getPaginateOrder(int page, int rows);
        OrderList getOrderById(int orderId);
    }
}
