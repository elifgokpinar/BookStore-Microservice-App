using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public string BookId { get; set; }
        public string BookName { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }

    }
}
