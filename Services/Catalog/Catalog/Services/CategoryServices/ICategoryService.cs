using Catalog.Dtos.CategoryDtos;

namespace Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto request);
        Task UpdateCategoryAsync(UpdateCategoryDto request);
        Task DeleteCategoryAsync(string id);
        Task<CategoryDto> GetCategoryByIdAsync(string id);
    }
}
