using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommand
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CityId { get; set; }
        public string Detail { get; set; }
    }
}
