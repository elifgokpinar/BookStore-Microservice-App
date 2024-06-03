using Entity.Concrete;
using Entity.Enums;

namespace Cargo.Dto.Dtos
{
    public class CreateCargoDetailDto
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public long Barcode { get; set; }
        public CargoStatus Status { get; set; }
        public long CargoCompanyId { get; set; }
    }
}
