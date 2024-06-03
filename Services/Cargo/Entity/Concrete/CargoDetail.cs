

using Entity.Enums;

namespace Entity.Concrete
{
    public class CargoDetail
    {
        public long Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public long Barcode { get; set; }
        public CargoStatus Status { get; set; }
        public long CargoCompanyId { get; set; }
        public CargoCompany CargoCompany { get; set; }
    }
}
