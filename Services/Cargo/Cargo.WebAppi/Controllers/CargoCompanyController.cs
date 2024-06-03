using Cargo.Business.Abstract;
using Cargo.Dto.Dtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCompanyController : ControllerBase
    {
        private readonly ICargoCompanyService _cargoCompanyService;

        public CargoCompanyController(ICargoCompanyService cargoCompanyService)
        {
            _cargoCompanyService = cargoCompanyService;
        }

        [HttpGet]
        public IActionResult GetCargoCompanyList()
        {
            var list = _cargoCompanyService.TGetAll();
            return Ok(list);
        }

        [HttpDelete]
        public IActionResult GetCargoCompanyById(long id)
        {
            var value = _cargoCompanyService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCargoCompany(CreateCargoCompanyDto request)
        {
            var value = new CargoCompany
            {
                Name = request.Name
            };

            _cargoCompanyService.TInsert(value);

            return Ok("CargoCompany added.");
        }

        [HttpGet("{id}")]
        public IActionResult DeleteCargoCompany(long id)
        {
            _cargoCompanyService.TDelete(id);

            return Ok("Cargo Company deleted.");
        }

        [HttpPut]
        public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto request)
        {
            var value = new CargoCompany
            {
                Id = request.Id,
                Name = request.Name
            };

            _cargoCompanyService.TUpdate(value);

            return Ok("CargoCompany updated.");
        }
    }
}
