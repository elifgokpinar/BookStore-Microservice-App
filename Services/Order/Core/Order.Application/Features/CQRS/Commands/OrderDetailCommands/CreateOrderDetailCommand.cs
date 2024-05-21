

namespace Order.Application.Features.CQRS.Commands.OrderDetailCommands
{
    public class CreateOrderDetailCommand
    {
        public string BookId { get; set; }
        public string BookName { get; set; }
        public long OrderId { get; set; }
    }
}
