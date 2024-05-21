using Microsoft.AspNetCore.Mvc;
using Order.Application.Features.CQRS.Commands.AddressCommands;
using Order.Application.Features.CQRS.Handlers.AddressHandlers;
using Order.Application.Features.CQRS.Queries.AddressQueries;

namespace Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler;
        private readonly GetAddressQueryHandler _getAddressQueryHandler;
        private readonly CreateAddressCommandHandler _createAddressCommandHandler;
        private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;
        private readonly RemoveAddressCommandHandler _removeAddressCommandHandler;

      public AddressController(GetAddressByIdQueryHandler getAddressByIdQueryHandler, GetAddressQueryHandler getAddressQueryHandler, CreateAddressCommandHandler createAddressCommandHandler,
          UpdateAddressCommandHandler updateAddressCommandHandler, RemoveAddressCommandHandler removeAddressCommandHandler)
        {
            _getAddressByIdQueryHandler = getAddressByIdQueryHandler;
            _getAddressQueryHandler = getAddressQueryHandler;
            _createAddressCommandHandler = createAddressCommandHandler;
            _updateAddressCommandHandler = updateAddressCommandHandler;
            _removeAddressCommandHandler = removeAddressCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAddressList()
        {
            var list = _getAddressQueryHandler.Handle();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(long id)
        {
            var request = new GetAddressByIdQuery(id);
            var address = _getAddressByIdQueryHandler.Handle(request);
            return Ok(address);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressCommand command)
        {
            await _createAddressCommandHandler.Handle(command);
            return Ok("Address is added successfully.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress(UpdateAddressCommand command)
        {
            await _updateAddressCommandHandler.Handle(command);
            return Ok("Addres is updated.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAddress(long id)
        {
            var request = new RemoveAddressCommand(id);
            await _removeAddressCommandHandler.Handle(request);
            return Ok("Address is removed.");
        }

    }
}
