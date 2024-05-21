
namespace Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressByIdQuery
    {
        public long Id { get; set; }

        public GetAddressByIdQuery(long id)
        {
            Id = id;
        }
    }
}
