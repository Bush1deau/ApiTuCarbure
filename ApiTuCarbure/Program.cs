
using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using ApiTuCarbure.RepositoryLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Dependency Injection

builder.Services.AddSingleton<Settings, Settings>();
builder.Services.AddScoped<IRepository<Station>, StationRepository>();
builder.Services.AddScoped<IRepository<Brand>, BrandRepository>();
builder.Services.AddScoped<IRepository<Fuel>, FuelRepository>();
builder.Services.AddScoped<IRepositoryS<Statement>, StatementRepository >();

builder.Services.AddDbContext<TuCarburesContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();