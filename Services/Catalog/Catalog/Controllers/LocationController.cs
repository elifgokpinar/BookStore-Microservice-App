using Catalog.Dtos.LocationDtos;
using Catalog.Services.BookServices;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLocation()
        {
            var list = await _locationService.GetAllLocationAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocationById(string id)
        {
            var location = await _locationService.GetLocationByIdAsync(id);
            return Ok(location);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationDto request)
        {
            await _locationService.CreateLocationAsync(request);
            return Ok("Başarıyla eklendi.");
        }

    }
}
