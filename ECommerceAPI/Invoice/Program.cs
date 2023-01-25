using ECommerce.Data.Context;
using ECommerce.Repository.Implements;
using ECommerce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Invoice.Controllers;
using ECommerce.Service.Query.Invoice;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddAutoMapper(typeof(InvoiceController));
builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddMediatR(typeof(GetAllInvoiceQuery).Assembly);
builder.Services.AddDbContext<InvoiceDbContext>(o => o.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=ECommerce;User Id=postgres;Password=postgres;"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
