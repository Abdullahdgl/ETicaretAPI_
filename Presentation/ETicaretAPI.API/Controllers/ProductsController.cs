﻿using ETicaretAP.Domain.Entites;

using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.RepositorieS;
using ETicaretAPI.Application.ViewModels.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
			return Ok(_productReadRepository.GetAll(false).Select(p => new
			{
				p.Id,
				p.Name,
				p.Stock,
				p.Price,
				p.CreatedDate,
				p.UpdatedDate,

			}));
		}

		// birde parametreli bir get metodu ile çağıralım!
		[HttpGet("{id}")] 
		public async Task<IActionResult> Get(string id)
		{
			return Ok(await _productReadRepository.GetByIdAsync(id, false));
		}

		[HttpPost]
		public async Task<IActionResult> Post(VM_Create_Product model)
		{
		
			await _productWriteRepository.AddAsync(new()
			{
			Name = model.Name,
			Price = model.Price,
			Stock = model.Stock,
			});
			await _productWriteRepository.SaveAsync();
			return StatusCode((int)HttpStatusCode.Created);

			//return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> Put(VM_Update_Product model)
		{
			Product product = await _productReadRepository.GetByIdAsync(model.Id);
			product.Stock = model.Stock;
			product.Name = model.Name;
			product.Price = model.Price;
			await _productWriteRepository.SaveAsync();
			return Ok();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(string id)
		{
			await _productWriteRepository.RemoveAsync(id);
			await _productWriteRepository.SaveAsync();
			return Ok();
		}
	
	}
}
