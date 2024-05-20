using AutoMapper;
using Catalog.Dtos.BookDtos;
using Catalog.Dtos.CategoryDtos;
using Catalog.Dtos.LocationDtos;
using Catalog.Entities;
using Catalog.Settings;
using MongoDB.Driver;

namespace Catalog.Services.BookServices
{
    public class LocationService : ILocationService
    {
        private readonly IMongoCollection<Location> _location;
        private readonly IMapper _mapper;

        public LocationService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _location = database.GetCollection<Location>(databaseSettings.LocationCollectionName);
            _mapper = mapper;
        }

        public async Task CreateLocationAsync(CreateLocationDto request)
        {
            var location = _mapper.Map<Location>(request);
            await _location.InsertOneAsync(location);
        }

        public async Task DeleteLocationAsync(string id)
        {
            await _location.DeleteOneAsync(id);
        }

        public async Task<List<LocationDto>> GetAllLocationAsync()
        {
            var locations = await _location.Find(x => true).ToListAsync();
            return  _mapper.Map<List<LocationDto>>(locations);
        }

        public async Task<LocationDto> GetLocationByIdAsync(string id)
        {
            var location = await _location.Find<Location>(q => q.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<LocationDto>(location);
        }
    }
}
