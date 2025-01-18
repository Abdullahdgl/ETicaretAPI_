using ETicaretAP.Domain.Entites;
using ETicaretAPI.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
	public class CustomerService : ICustomerService
	{
	
			public List<Customer> GetCustomers()
		   => new() {
			new(){
				Id = Guid.NewGuid(),Name = "Customer 1"

			}, };
		}
	
}
