using System;

namespace OrderProcessing.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Order_Date { get; set; }
        public Guid CustomerId { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }

    public enum OrderStatus
    {
        Processing, Shipped, Delivered
    }
}
