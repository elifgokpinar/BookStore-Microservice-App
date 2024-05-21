using Order.Application.Features.CQRS.Results.AddressResults;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;
        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var list = await _repository.GetAllAsync();
            return list.Select(q => new GetAddressQueryResult
            {
                Id = q.Id,
                Name = q.Name,  
                CityId = q.CityId,
                Detail = q.Detail
            }).ToList();
        }
    }
}
