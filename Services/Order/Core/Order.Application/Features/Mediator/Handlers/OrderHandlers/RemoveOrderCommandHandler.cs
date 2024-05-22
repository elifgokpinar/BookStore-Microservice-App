
using MediatR;
using Order.Application.Features.Mediator.Commands.OrderCommands;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.Mediator.Handlers.OrderHandlers
{
    public class RemoveOrderCommandHandler : IRequestHandler<RemoveOrderCommand>
    {

        private readonly IRepository<OrderInfo> _repository;

        public RemoveOrderCommandHandler(IRepository<OrderInfo> repository)
        {
            _repository = repository;
        } 

        public async Task Handle(RemoveOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(order);
        }
    }
}
