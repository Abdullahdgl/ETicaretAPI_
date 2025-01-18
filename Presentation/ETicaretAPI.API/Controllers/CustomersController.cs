using ETicaretAPI.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{

		private readonly ICustomerService _customerService;

		public CustomersController(ICustomerService customerService)
		{
			_customerService = customerService;
		}
		[HttpGet]
		public IActionResult GetCustomers()
		{
			var customers = _customerService.GetCustomers();
			return Ok(customers);
		}
	}
}
