﻿using ETicaretAP.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions
{
	public interface IProductService
	{
		List<Product> GetProducts();
		List<Product> GetProductsDb();

	}
}
