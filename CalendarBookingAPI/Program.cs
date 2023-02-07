using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.Services;
using CalendarBooking.ApplicationLayer.Services.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer;
using CalendarBooking.InfrastructureLayer.Data;
using CalendarBooking.InfrastructureLayer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentService, StudentServices>();
builder.Services.AddScoped<IStudentQueryService, StudentQueryService>();

builder.Services.AddDbContext<DBContext>(
    options =>
    options.UseSqlServer(
            x => x.MigrationsAssembly("CalendarBooking.API")));


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
