using Catalog.Dtos.BookDtos;
using Catalog.Dtos.CategoryDtos;
using Catalog.Services.BookServices;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBook()
        {
            var list = await _bookService.GetAllBookAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var category = await _bookService.GetBookByIdAsync(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateBookDto request)
        {
            await _bookService.CreateBookAsync(request);
            return Ok("Başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateBookDto request)
        {
            await _bookService.UpdateBookAsync(request);
            return Ok("Başarıyla güncellendi.");
        }
    }
}
