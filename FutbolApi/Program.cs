using Microsoft.EntityFrameworkCore;
using FutbolApi.Context;
using FutbolApi.Models;
using System.Text.Json.Serialization;
using FutbolApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Agregar contexto de Base de datos
builder.Services.AddDbContext<FutbolContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSql")));

builder.Services.AddScoped<IJugadorRepository, JugadorRepository>();
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

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
