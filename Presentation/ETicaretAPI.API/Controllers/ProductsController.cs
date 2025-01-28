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

		readonly private IOrderWriteRepository _orderWriteRepository;
		readonly private IOrderReadRepository _orderReadRepository;


		readonly private ICustomerWriteRepository _customerWriteRepository;
		

		public ProductsController(IProductWriteRepository productWriteRepository,
			IProductReadRepository productReadRepository,
			IOrderWriteRepository orderWriteRepository,
			ICustomerWriteRepository customerWriteRepository,
			IOrderReadRepository orderReadRepository)
		{
			_productReadRepository = productReadRepository;
			_productWriteRepository = productWriteRepository;
			_orderWriteRepository = orderWriteRepository;
			_customerWriteRepository = customerWriteRepository;
			_orderReadRepository = orderReadRepository;
		}


		[HttpGet]

		public IActionResult Get()
		{
			return(Ok("Merhabalar,"));
		}
		//[HttpGet]
		//public async Task Get()
		//{
			#region Orneklem
			//1.Örnek
			//	await _productWriteRepository.AddRangeAsync(new()
			//	{
			//		new(){Id=Guid.NewGuid(), Name="Prouduct 1", Price=100, CreatedDate=DateTime.UtcNow,Stock=10 },
			//		new(){Id=Guid.NewGuid(), Name="Prouduct 2", Price=200, CreatedDate=DateTime.UtcNow,Stock=20 },
			//		new(){Id=Guid.NewGuid(), Name="Prouduct 3", Price=300, CreatedDate=DateTime.UtcNow,Stock=30 },
			//	});
			//var count = 	await _productWriteRepository.SaveAsync();

			//2.örnek 
			//Product p = await _productReadRepository.GetByIdAsync("d74d68c0-0fbc-4325-8652-ad1c40a53e05");
			//p.Name = "Yeni Product 10";
			//await _productWriteRepository.SaveAsync();

			//3.Örnek


			//await _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500f, Stock = 10, CreatedDate = DateTime.UtcNow });
			//await _productWriteRepository.SaveAsync();

			//4.Örnek

			//var customerId = Guid.NewGuid();
			//await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "Muiiddin" });

			//await _orderWriteRepository.AddAsync(new() { Description = "BLA BLA BLA ", Address = "Malatya", CustomerId = customerId });
			//await _orderWriteRepository.AddAsync(new() { Description = "BLA BLA BLA  2", Address = "Bartın", CustomerId = customerId });

			//await _orderWriteRepository.SaveAsync();

			//5.Örnek Güncelleme 

			//Order order = await _orderReadRepository.GetByIdAsync("b679593b-c937-4706-bf95-362df738e625");
			//order.Address = "Bilecik";
			//await _orderWriteRepository.SaveAsync();


			#endregion


		//}

		//[HttpGet("{id}")]
		//public async Task<IActionResult> Get(string id)
		//{
		//	Product product = await _productReadRepository.GetByIdAsync(id);
		//	return Ok(product);
		//}
	}
}
