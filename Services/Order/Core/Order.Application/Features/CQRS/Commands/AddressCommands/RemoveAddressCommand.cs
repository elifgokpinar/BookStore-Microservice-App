

namespace Order.Application.Features.CQRS.Commands.AddressCommands
{
    public class RemoveAddressCommand
    {
        public long Id { get; set; }

        public RemoveAddressCommand(long id)
        {
            Id = id;
        }
    }
}
