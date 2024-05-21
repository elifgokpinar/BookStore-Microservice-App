
namespace Order.Application.Features.CQRS.Results.AddressResults
{
    public class GetAddressQueryResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CityId { get; set; }
        public string Detail { get; set; }
    }
}
