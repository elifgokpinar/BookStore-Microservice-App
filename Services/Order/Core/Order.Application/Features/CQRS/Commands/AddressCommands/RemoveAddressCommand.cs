

namespace Order.Application.Features.CQRS.Commands.AddressCommands
{
    public class RemoveAddressCommand
    {
        public long Id { get; set; }

        public RemoveAddressCommand(int id)
        {
            Id = id;
        }
    }
}
