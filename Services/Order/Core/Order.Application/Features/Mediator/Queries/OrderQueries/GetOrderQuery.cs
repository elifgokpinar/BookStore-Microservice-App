using MediatR;
using Order.Application.Features.Mediator.Results.OrderResults;

namespace Order.Application.Features.Mediator.Queries.OrderQueries
{
    public class GetOrderQuery : IRequest<List<GetOrderQueryResult>>
    {
    }
}
