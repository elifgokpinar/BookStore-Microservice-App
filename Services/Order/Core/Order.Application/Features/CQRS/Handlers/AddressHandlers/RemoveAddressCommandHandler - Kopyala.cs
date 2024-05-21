using Order.Application.Features.CQRS.Commands.AddressCommands;
using Order.Application.Interfaces;
using Order.Domain.Entities;

namespace Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class RemoveAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommand removeAddressCommand)
        {
            var address = await _repository.GetByIdAsync(removeAddressCommand.Id);
            await _repository.DeleteAsync(address);
        }
    }
}
