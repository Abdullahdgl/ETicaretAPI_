using ETicaretAP.Domain.Entites;
using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.RepositorieS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
	

		readonly private IProductReadRepository _productReadRepository;
		readonly private IProductWriteRepository _productWriteRepository;

	

		public ProductsController(
			IProductWriteRepository productWriteRepository,
			IProductReadRepository productReadRepository)
			
		{
			_productReadRepository = productReadRepository;
			_productWriteRepository = productWriteRepository;
			
		}


		[HttpGet]

		public async Task<IActionResult>Get()
		{
			return (Ok("Merhabalar,"));
		}
		
	
	}
}
