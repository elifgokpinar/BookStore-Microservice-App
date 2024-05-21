using Order.Application.Features.CQRS.Queries.AddressQueries;
using Order.Application.Features.CQRS.Results.AddressResults;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;
        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery getAddressByIdQuery)
        {
            var address = await _repository.GetByIdAsync(getAddressByIdQuery.Id);
            return new GetAddressByIdQueryResult
            {
                Id = address.Id,
                Name = address.Name,
                CityId = address.CityId,
                Detail = address.Detail
            };


        }
    }
}
