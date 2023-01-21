using CrudSchool.Extensions;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Configure all cors policy
builder.Services.ConfigureCors();
// Dependency injection from all interfaces from core
builder.Services.AddApplicationServices();

// TODO 20-01-2023: This part obtains a connection string from the appsettings.json file.
// "remember" you can give a string connection acording to your path configured.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// TODO 20-01-2023: This part configures the DbContext to use the SQL Server provider.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
