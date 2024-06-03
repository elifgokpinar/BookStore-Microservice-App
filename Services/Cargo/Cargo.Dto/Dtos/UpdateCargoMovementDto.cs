namespace Cargo.Dto.Dtos
{
    public class UpdateCargoMovementDto
    {
        public long Id { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
