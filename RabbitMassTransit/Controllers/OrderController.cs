
using Microsoft.AspNetCore.Mvc;
using RabbitMassTransit.Model;
using RabbitMassTransit.Services.Interfaces;

namespace RabbitMassTransit.Controllers
{
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> Order([FromBody] OrderModel model){
            if (ModelState.IsValid)
            return BadRequest(model);
            var result = await _orderService.CreatesOrder(model);
            return Ok(result);
        }

    }
}