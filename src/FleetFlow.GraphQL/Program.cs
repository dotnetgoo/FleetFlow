using FleetFlow.DAL.DbContexts;
using FleetFlow.GraphQL.Extensions;
using FleetFlow.GraphQL.Queries;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Mappers;
using FleetFlow.Service.Services;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQLService();

builder.Services.AddCustomServices();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<FleetFlowDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Init accessor
if(app.Services.GetRequiredService<IHttpContextAccessor>() != null)
{
    HttpContextHelper.Accessor = app.Services.GetRequiredService<IHttpContextAccessor>();
}

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
