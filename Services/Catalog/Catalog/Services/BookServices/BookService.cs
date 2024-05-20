using AutoMapper;
using Catalog.Dtos.BookDtos;
using Catalog.Entities;
using Catalog.Settings;
using MongoDB.Driver;

namespace Catalog.Services.BookServices
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _book;
        private readonly IMapper _mapper;

        public BookService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _book = database.GetCollection<Book>(databaseSettings.BookCollectionName);
            _mapper = mapper;
        }
        public async Task CreateBookAsync(CreateBookDto request)
        {
            var book = _mapper.Map<Book>(request);
            await _book.InsertOneAsync(book);
        }

        public async Task DeleteBookAsync(string id)
        {
            await _book.DeleteOneAsync(id);
        }

        public async Task<List<BookDto>> GetAllBookAsync()
        {
            var books = await _book.Find(x => true).ToListAsync();
            return _mapper.Map<List<BookDto>>(books);
        }

        public async Task<BookDto> GetBookByIdAsync(string id)
        {
            var book = await _book.Find<Book>(x => x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<BookDto>(book);
        }

        public async Task UpdateBookAsync(UpdateBookDto request)
        {
            var book = _mapper.Map<Book>(request);
            await _book.FindOneAndReplaceAsync(q => q.Id == request.Id, book);
        }

    }
}
