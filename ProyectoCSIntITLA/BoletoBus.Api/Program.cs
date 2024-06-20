using BoletoBus.Infraestructure.Context;
using BoletoBus.Ioc.Dependencies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 
 
builder.Services.AddDbContext<BusTicketContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BusTicketContext")));

builder.Services.AddAsientoDependency();
builder.Services.AddBusDependency();
builder.Services.AddReservaDependency();
builder.Services.AddReservaDetalleDependency();
builder.Services.AddRutaDependency();
builder.Services.AddUsuarioDependency();
builder.Services.AddViajeDependency();




builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
