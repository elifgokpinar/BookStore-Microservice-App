using MediatR;
using Microsoft.AspNetCore.Mvc;
using Order.Application.Features.Mediator.Commands.OrderCommands;
using Order.Application.Features.Mediator.Queries.OrderQueries;

namespace Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderList()
        {
            var list = await _mediator.Send(new GetOrderQuery()); // IRequestten kim miras alıyorsa yazıyoruz.
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(long id)
        {
            var order = await _mediator.Send(new GetOrderByIdQuery(id));
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
        {
            await _mediator.Send(request);
            return Ok("Order is added.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommand request)
        {
            await _mediator.Send(request);
            return Ok("Order is updated.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(long id)
        {
            await _mediator.Send(new RemoveOrderCommand(id));
            return Ok("Order is deleted.");
        }

    }
}
