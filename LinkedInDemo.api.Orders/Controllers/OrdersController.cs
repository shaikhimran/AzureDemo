using LinkedInDemo.api.Orders.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinkedInDemo.api.Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private IOrdersProvider OrdersProvider { get; set; }
        public OrdersController(IOrdersProvider orderssProvider)
        {
            this.OrdersProvider = orderssProvider;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(this.OrdersProvider.GetOrdersAsync());
        }
    }
}
