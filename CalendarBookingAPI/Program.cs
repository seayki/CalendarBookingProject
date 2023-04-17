using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;

using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using CalendarBooking.InfrastructureLayer.Queries;
using CalendarBooking.InfrastructureLayer.Commands;
using CalendarBooking.InfrastructureLayer.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.ApplicationLayer.UnitOfWork;
using CalendarBooking.InfrastructureLayer.DomainServices;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.InfrastructureLayer.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Angiver den implementation min service skal bruge.

// Custom queries og commands


// Default queries og commands
builder.Services.AddScoped<IStudentQueryService, StudentQueryService>();
builder.Services.AddScoped<IStudentCommandService, StudentCommandService>();
builder.Services.AddScoped<ICalendarQueryService, CalendarQueryService>();
builder.Services.AddScoped<ICalendarCommandService, CalendarCommandService>();
builder.Services.AddScoped<IGroupQueryService, GroupQueryService>();
builder.Services.AddScoped<IGroupCommandService, GroupCommandService>();
builder.Services.AddScoped<ITimeslotQueryService, TimeslotQueryService>();
builder.Services.AddScoped<ITimeslotCommandService, TimeslotCommandService>();
builder.Services.AddScoped<IBookingQueryService, BookingQueryService>();
builder.Services.AddScoped<IBookingCommandService, BookingCommandService>();
builder.Services.AddScoped<ITeacherQueryService, TeacherQueryService>();
builder.Services.AddScoped<ITeacherCommandService, TeacherCommandService>();

// Repos
builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
builder.Services.AddScoped<ICalendarRepo, CalendarRepo>();
builder.Services.AddScoped<ITimeslotRepo, TimeslotRepo>();
builder.Services.AddScoped<IGroupRepo, GroupRepo>();
builder.Services.AddScoped<IBookingRepo, BookingRepo>();

// UnitOfWork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Domain Services
builder.Services.AddScoped<IBookingDomainService, BookingDomainService>();
builder.Services.AddScoped<ITimeslotDomainService, TimeslotDomainService>();




builder.Services.AddDbContext<DBContext>(
    options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CalendarBookingProjectDatabase"),
            db => db.MigrationsAssembly("CalendarBookingProject.DatabaseMigrations"))) ;
//builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(StudentBookingQuery)));
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
