
namespace Catalog.Dtos.BookDtos
{
    public class CreateBookDto
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public string Year { get; set; }

        public string Description { get; set; }

        public string CategoryId { get; set; }

        public string LocationId { get; set; }

    }
}
