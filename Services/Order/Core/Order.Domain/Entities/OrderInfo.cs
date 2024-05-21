
namespace Order.Domain.Entities
{
    public class OrderInfo
    {
        public int Id { get; set; }

        public string  UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public List<OrderDetail> Details { get; set; }
    }
}
