
using MediatR;
using Order.Application.Features.Mediator.Commands.OrderCommands;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.Mediator.Handlers.OrderHandlers
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {

        private readonly IRepository<OrderInfo> _repository;

        public UpdateOrderCommandHandler(IRepository<OrderInfo> repository)
        {
            _repository = repository;
        } 

        public async Task Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _repository.GetByIdAsync(request.Id);
            order.UserId = request.UserId;
            order.TotalPrice = request.TotalPrice;
            order.ModifiedDate = DateTime.UtcNow;
            await _repository.UpdateAsync(order);
        }
    }
}
