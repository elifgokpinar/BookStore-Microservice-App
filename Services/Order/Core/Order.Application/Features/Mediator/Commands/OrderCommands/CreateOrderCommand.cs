using MediatR;

namespace Order.Application.Features.Mediator.Commands.OrderCommands
{
    public class CreateOrderCommand : IRequest
    {
        public string UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
