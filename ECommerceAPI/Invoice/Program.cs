using Data.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Base;
using Repository.Implements;
using Repository.Interface;
using Service.Query;
using MediatR;
using Invoice.Controllers;

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
