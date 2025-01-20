using ETicaretAP.Domain.Entites;
using ETicaretAP.Domain.Entites.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Contexts
{
	public class ETicaretAPIDbContext : DbContext
	{
		public ETicaretAPIDbContext(DbContextOptions options) : base(options)
		{
		
		}

		
		


		public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
		public DbSet<Customer> Customers { get; set; }

		/*
		 * her saveChangeAsync tetiklendiğinde insert ve update yapılan tüm dataları elde edip,üzerlerine istediğim değişikliği yapıp, ardınında saveChangesAsync i tekrardan devre sokabilirim.
		 * 
		 */


		public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			//ChangeTracker : Entityler üzerinde yapılan değişikliklerin  ya da yeni eklenen verinin yapılanmasını sağlayan property'dir. changeTracker neyi yakalar sorusuna ise, update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar. 
			//Entries : Bana, değişiklik yapılan, sürece giren bütün girdileri getiriyor. ve her sürece giren herhangi bir girdiyi seçebiliyorum. sürece giren bütün baseEntityleri yakalamak için aşağıdaki ideal bir örneği yazdım.
			var datas = ChangeTracker
				.Entries<BaseEntity>();
			foreach (var data in datas)
			{
				_ = data.State switch
				{
					EntityState.Added => data.Entity.CreatedDate= DateTime.UtcNow,
					EntityState.Modified => data.Entity.UpdatedDate= DateTime.UtcNow
				};
			}

			return await base.SaveChangesAsync(cancellationToken);
		}


	}

}
