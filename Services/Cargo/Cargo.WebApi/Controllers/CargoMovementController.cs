using Cargo.Business.Abstract;
using Cargo.Dto.Dtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoMovementController : ControllerBase
    {
        private readonly ICargoMovementService _cargoMovementService;

        public CargoMovementController(ICargoMovementService cargoMovementService)
        {
            _cargoMovementService = cargoMovementService;
        }

        [HttpGet]
        public IActionResult GetCargoMovementList()
        {
            var list = _cargoMovementService.TGetAll();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoMovementById(long id)
        {
            var value = _cargoMovementService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCargoMovement(CreateCargoMovementDto request)
        {
            var value = new CargoMovement
            {
                Barcode = request.Barcode,
                Description = request.Description,
                CreatedDate = DateTime.Now,
            };

            _cargoMovementService.TInsert(value);

            return Ok("Cargo Movement added.");
        }

        [HttpDelete]
        public IActionResult DeleteCargoDetail(long id)
        {
            _cargoMovementService.TDelete(id);

            return Ok("Cargo Movement deleted.");
        }

        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoMovementDto request)
        {
            var value = new CargoMovement
            {
                Id = request.Id,
                Barcode = request.Barcode,
                Description = request.Description,
                CreatedDate = DateTime.Now,
            };

            _cargoMovementService.TUpdate(value);

            return Ok("Cargo Movement updated.");
        }
    }
}
