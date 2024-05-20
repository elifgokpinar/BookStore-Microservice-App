using AutoMapper;
using Catalog.Dtos.CategoryDtos;
using Catalog.Entities;
using Catalog.Settings;
using MongoDB.Driver;

namespace Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _category;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _category = database.GetCollection<Category>(databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        async Task ICategoryService.CreateCategoryAsync(CreateCategoryDto request)
        {
            var category = _mapper.Map<Category>(request);
            await _category.InsertOneAsync(category);
        }

        async Task ICategoryService.DeleteCategoryAsync(string id)
        {
            await _category.DeleteOneAsync(id);
        }

        async Task<List<CategoryDto>> ICategoryService.GetAllCategoryAsync()
        {
            var list = await _category.Find(x => true).ToListAsync();
            return _mapper.Map<List<CategoryDto>>(list);
        }

        async Task<CategoryDto> ICategoryService.GetCategoryByIdAsync(string id)
        {
            var category = await _category.Find<Category>(x => x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<CategoryDto>(category);
        }

        async Task ICategoryService.UpdateCategoryAsync(UpdateCategoryDto request)
        {
            var category = _mapper.Map<Category>(request);
            await _category.FindOneAndReplaceAsync(x => x.Id == request.Id, category);
        }
    }
}
