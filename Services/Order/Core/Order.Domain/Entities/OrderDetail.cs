

using System.ComponentModel.DataAnnotations.Schema;

namespace Order.Domain.Entities
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public string BookId { get; set; }
        public string BookName { get; set; }
        public long OrderId { get; set; }

        [ForeignKey("OrderId")]
        public OrderInfo orderInfo { get; set; }

    }
}
