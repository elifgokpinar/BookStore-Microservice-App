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
    public class CargoDetailController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet]
        public IActionResult GetCargoDetailList()
        {
            var list = _cargoDetailService.TGetAll();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(long id)
        {
            var value = _cargoDetailService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto request)
        {
            var value = new CargoDetail
            {
                Receiver = request.Receiver,
                Sender = request.Sender,
                Barcode = request.Barcode,
                CargoCompanyId = request.CargoCompanyId,
                Status = request.Status                
            };

            _cargoDetailService.TInsert(value);

            return Ok("Cargo Detail added.");
        }

        [HttpDelete]
        public IActionResult DeleteCargoDetail(long id)
        {
            _cargoDetailService.TDelete(id);
            return Ok("Cargo Detail deleted.");
        }

        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto request)
        {
            var value = new CargoDetail
            {
                Id = request.Id,
                Receiver = request.Receiver,
                Sender = request.Sender,
                Barcode = request.Barcode,
                CargoCompanyId = request.CargoCompanyId,
                Status = request.Status
            };

            _cargoDetailService.TUpdate(value);

            return Ok("Cargo Detail updated.");
        }
    }
}
