﻿using ETicaretAP.Domain.Entites;
using ETicaretAPI.Application.RepositorieS;
using ETicaretAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
	public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
	{
		public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
		{
		}
	}
}
