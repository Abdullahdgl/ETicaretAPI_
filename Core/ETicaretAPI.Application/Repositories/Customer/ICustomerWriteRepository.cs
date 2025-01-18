using ETicaretAP.Domain.Entites;
using ETicaretAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.RepositorieS
{ 
	public interface ICustomerWriteRepository: IWriteRepository<Customer>
	{
	}
}
