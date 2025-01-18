using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence;
using ETicaretAPI.Persistence.Concretes;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();
//builder.Services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("Server=localhost;Port=5433;Database=ETicaretAPIDb;User Id=admin;Password=password;"));


// Add services to the container.

builder.Services.AddControllers();
#region addSingleton ile örneði
//builder.Services.AddSingleton<IProductService, ProductService>();
//builder.Services.AddSingleton<ICustomerService, CustomerService>();
#endregion

#region AddScoped ÖRNEÐÝ

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

#endregion


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
