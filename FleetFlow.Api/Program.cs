using FleetFlow.Api.Extensions;
using FleetFlow.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrate DbContext to DI container
builder.Services.AddDbContext<FleetFlowDbContext>(
    options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection") 
        ?? throw new InvalidOperationException("Cannot access server!"), b => b.MigrationsAssembly("FleetFlow.Api")));

builder.Services.AddCustomServices();

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
