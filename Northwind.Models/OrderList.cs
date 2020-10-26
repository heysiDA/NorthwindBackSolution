using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Models
{
    public class OrderList
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalRecords { get; set; }
        public List<OrderItemList> OrderDetails { get; set; }
        public void SetDetails(List<OrderItemList> orderD)
        {
            OrderDetails = orderD.Where(x => x.OrderId == OrderId).ToList();
        }
    }
}
