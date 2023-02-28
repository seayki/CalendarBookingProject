using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.Services;
using CalendarBooking.ApplicationLayer.Services.CalendarServices;
using CalendarBooking.ApplicationLayer.Services.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using CalendarBooking.InfrastructureLayer.Queries;
using CalendarBooking.InfrastructureLayer.Services;
using CalendarBooking.InfrastructureLayer.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentService, StudentServices>();
builder.Services.AddScoped<IStudentQueryService, StudentQueryService>();

builder.Services.AddScoped<ICalendarService, CalendarServices>();
builder.Services.AddScoped<ICalendarQueryService, CalendarQueryService>();
builder.Services.AddScoped<IStudentCommandService, StudentCommandService>();
builder.Services.AddScoped<IStudentBookingQuery, StudentBookingQuery>();

builder.Services.AddDbContext<DBContext>(
    options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CalendarBookingProjectDatabase"),
            db => db.MigrationsAssembly("CalendarBookingProject.DatabaseMigrations"))) ;
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(StudentBookingQuery)));

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
