using FleetFlow.DAL.DbContexts;
using FleetFlow.GraphQL.Extensions;
using FleetFlow.Service.Mappers;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddGraphQLService();

builder.Services.AddCustomServices();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<FleetFlowDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// Init accessor
if (app.Services.GetRequiredService<IHttpContextAccessor>() != null)
{
    HttpContextHelper.Accessor = app.Services.GetRequiredService<IHttpContextAccessor>();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();
