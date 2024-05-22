
using MediatR;
using Order.Application.Features.Mediator.Queries.OrderQueries;
using Order.Application.Features.Mediator.Results.OrderResults;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.Mediator.Handlers.OrderHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, GetOrderByIdQueryResult>
    {

        private readonly IRepository<OrderInfo> _repository;

        public GetOrderByIdQueryHandler(IRepository<OrderInfo> repository)
        {
            _repository = repository;
        }
 
        public async Task<GetOrderByIdQueryResult> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _repository.GetByIdAsync(request.Id);
            return  new GetOrderByIdQueryResult
            {
                Id = order.Id,
                UserId = order.UserId,
                CreatedDate = order.CreatedDate,
                ModifiedDate = order.ModifiedDate,
                TotalPrice = order.TotalPrice
            };
        }
    }
}
