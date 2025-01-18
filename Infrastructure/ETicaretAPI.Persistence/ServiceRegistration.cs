using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Concretes;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Repositories;
using ETicaretAPI.Application.RepositorieS;

namespace ETicaretAPI.Persistence
{
	public static class ServiceRegistration
	{
		//static olmasının nedeni biz bunun içerisinde extantion fonksiyon tanımlayacağız.
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			#region Singleton ile örneği
			//services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Singleton);

			//services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
			//services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();

			//services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
			//services.AddSingleton<IOrderWriteRepository, OrderWriteRespository>();

			//services.AddSingleton<IProductReadRepository, ProductReadRepository>();
			//services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
			#endregion
			services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

			services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
			services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

			services.AddScoped<IOrderReadRepository, OrderReadRepository>();
			services.AddScoped<IOrderWriteRepository, OrderWriteRespository>();

			services.AddScoped<IProductReadRepository, ProductReadRepository>();
			services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

		}
	}
}
