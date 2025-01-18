using ETicaretAP.Domain.Entites;
using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		#region Önceki örneklem!!!!
		//private readonly IProductService _productService;

		//public ProductsController(IProductService productService)
		//{
		//	_productService = productService;
		//}
		//[HttpGet]
		//public IActionResult GetProducts()
		//{
		//	var products = _productService.GetProducts();
		//	return Ok(products);
		//}
		#endregion
		readonly private IProductReadRepository _productReadRepository;
		readonly private IProductWriteRepository _productWriteRepository;
		public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
		{
			_productReadRepository = productReadRepository;
			_productWriteRepository = productWriteRepository;
		}

		[HttpGet]
		public async Task Get()
		{
			//	await _productWriteRepository.AddRangeAsync(new()
			//	{
			//		new(){Id=Guid.NewGuid(), Name="Prouduct 1", Price=100, CreatedDate=DateTime.UtcNow,Stock=10 },
			//		new(){Id=Guid.NewGuid(), Name="Prouduct 2", Price=200, CreatedDate=DateTime.UtcNow,Stock=20 },
			//		new(){Id=Guid.NewGuid(), Name="Prouduct 3", Price=300, CreatedDate=DateTime.UtcNow,Stock=30 },
			//	});
			//var count = 	await _productWriteRepository.SaveAsync();

			Product p = await _productReadRepository.GetByIdAsync("d74d68c0-0fbc-4325-8652-ad1c40a53e05");
			p.Name = "Yeni Product 10";
			await _productWriteRepository.SaveAsync();
		
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(string id)
		{
			Product product = await _productReadRepository.GetByIdAsync(id);
			return Ok(product);
		}
	}
}
