using Catalog.Dtos.BookDtos;
using Catalog.Dtos.CategoryDtos;
using Catalog.Dtos.LocationDtos;

namespace Catalog.Services.BookServices
{
    public interface ILocationService
    {
        Task<List<LocationDto>> GetAllLocationAsync();
        Task CreateLocationAsync(CreateLocationDto request);
        //Task UpdateLocationAsync(UpdateLocationDto request);
        Task DeleteLocationAsync(string id);
        Task<LocationDto> GetLocationByIdAsync(string id);
    }
}
