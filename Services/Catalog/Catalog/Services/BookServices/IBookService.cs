using Catalog.Dtos.BookDtos;
using Catalog.Dtos.CategoryDtos;

namespace Catalog.Services.BookServices
{
    public interface IBookService
    {
        Task<List<BookDto>> GetAllBookAsync();
        Task CreateBookAsync(CreateBookDto request);
        Task UpdateBookAsync(UpdateBookDto request);
        Task DeleteBookAsync(string id);
        Task<BookDto> GetBookByIdAsync(string id);
    }
}
