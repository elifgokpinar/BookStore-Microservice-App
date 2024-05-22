
using MediatR;
using Order.Application.Features.Mediator.Queries.OrderQueries;
using Order.Application.Features.Mediator.Results.OrderResults;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.Mediator.Handlers.OrderHandlers
{
    //GetOrderQuery tipinde request alır, GetOrderQueryResult tipinde döner.
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, List<GetOrderQueryResult>>
    {

        private readonly IRepository<OrderInfo> _repository;

        public GetOrderQueryHandler(IRepository<OrderInfo> repository)
        {
            _repository = repository;
        }
        //Cancellation token işlem devam ederken sayfayı yenilediğimizse iptal işlevini yönetir.
        public async Task<List<GetOrderQueryResult>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var list = await _repository.GetAllAsync();
            return list.Select(q => new GetOrderQueryResult
            {
                Id = q.Id,
                UserId = q.UserId,
                CreatedDate = q.CreatedDate,
                ModifiedDate = q.ModifiedDate,
                TotalPrice = q.TotalPrice
            }).ToList();
        }
    }
}
