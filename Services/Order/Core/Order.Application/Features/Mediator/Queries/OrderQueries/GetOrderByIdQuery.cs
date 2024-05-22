using MediatR;
using Order.Application.Features.Mediator.Results.OrderResults;
namespace Order.Application.Features.Mediator.Queries.OrderQueries
{
    public class GetOrderByIdQuery : IRequest<GetOrderByIdQueryResult>
    {
        public long Id { get; set; }
        public GetOrderByIdQuery(long id) {
            Id = id;
        }
    }
}
