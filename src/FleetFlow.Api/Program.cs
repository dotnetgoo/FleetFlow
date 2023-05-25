using FleetFlow.Api.Extensions;
using FleetFlow.Api.Middlewares;
using FleetFlow.Api.Models;
using FleetFlow.DAL.DbContexts;
using System.Text.Json.Serialization;
using FleetFlow.Shared.Helpers;
using FleetFlow.Service.Mappers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.m/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureSwagger();

builder.Services.AddHttpContextAccessor();

// terminal's location should be in FleetFlow.Api
// dotnet ef --project ..\FleetFlow.DAL\ migrations add [MigrationName]
builder.Services.AddDbContext<FleetFlowDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCustomServices();
builder.Services.AddAutoMapper(typeof(MapperProfile));

builder.Services.AddJwtService(builder.Configuration);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Administration", p => p.RequireRole("Admin", "SuperAdmin"));
    options.AddPolicy("AdminMerchant", p => p.RequireRole("Admin", "Merchant"));
    options.AddPolicy("Worker", p => p.RequireRole("Driver", "Picker", "Packer"));
});

// Convert Api Url name to dashcase
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new RouteTokenTransformerConvention(
                                        new ConfigureApiUrlName()));
});
builder.Services.AddControllersWithViews()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

// Updates db in early startup based on latest migration
app.ApplyMigrations();
app.InitAccessor();

// Getting wwwroot path
//EnvironmentHelper.WebRootPath = app.Services.GetRequiredService<IWebHostEnvironment>().WebRootPath;
EnvironmentHelper.WebRootPath = Path.GetFullPath("wwwroot");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
