using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MoneyManager.API;
using MoneyManager.API.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Configuration.AddJsonFile("ConnectionString.json");

var connectionString=builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddDbContext<MoneyManagerDbContext>(Options=>Options.UseSqlServer(connectionString));

builder.Services.AddIdentity<User,Role>().AddEntityFrameworkStores<MoneyManagerDbContext>();

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
