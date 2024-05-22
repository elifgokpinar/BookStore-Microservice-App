using MediatR;

namespace Order.Application.Features.Mediator.Commands.OrderCommands
{
    public class UpdateOrderCommand:IRequest
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
