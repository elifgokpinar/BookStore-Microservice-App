using MediatR;

namespace Order.Application.Features.Mediator.Commands.OrderCommands
{
    public class RemoveOrderCommand : IRequest
    {
        public long Id { get; set; }
        public RemoveOrderCommand(long id)
        {
            this.Id = id;
        }
    }
}
