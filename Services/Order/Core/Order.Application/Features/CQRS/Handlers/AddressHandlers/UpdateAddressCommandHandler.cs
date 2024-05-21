using Order.Application.Features.CQRS.Commands.AddressCommands;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand updateAddressCommand)
        {
            var address = await _repository.GetByIdAsync(updateAddressCommand.Id);
            address.Name = updateAddressCommand.Name;
            address.CityId = updateAddressCommand.CityId;
            address.Detail = updateAddressCommand.Detail;

            await _repository.UpdateAsync(address);
        }
    }
}
