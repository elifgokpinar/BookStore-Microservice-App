
using MediatR;
using Order.Application.Features.Mediator.Commands.OrderCommands;
using Order.Application.Features.Mediator.Queries.OrderQueries;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.Mediator.Handlers.OrderHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {

        private readonly IRepository<OrderInfo> _repository;

        public CreateOrderCommandHandler(IRepository<OrderInfo> repository)
        {
            _repository = repository;
        } 

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new OrderInfo
            {
                UserId = request.UserId,
                TotalPrice = request.TotalPrice,
                CreatedDate = DateTime.UtcNow,
            };

            await _repository.CreateAsync(order);
        }
    }
}
