﻿

namespace Order.Domain.Entities
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public string BookId { get; set; }
        public string BookName { get; set; }
        public long OrderId { get; set; }
        public OrderInfo order { get; set; }

    }
}
