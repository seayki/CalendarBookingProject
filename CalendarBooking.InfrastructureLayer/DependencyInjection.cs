using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace CalendarBooking.InfrastructureLayer
//{
//    public static class DependencyInjections
//    {
//        public static IServiceCollection ImplementPersistence(this IServiceCollection services, IConfiguration configuration)
//        {

//            services.AddDbContext<StudentDbContext>(options =>
//             options.UseSqlServer(configuration.GetConnectionString("Default Connection"),
//                b => b.MigrationsAssembly(typeof(StudentDbContext).Assembly.FullName)), ServiceLifetime.Transient);

//            services.AddScoped<IStudentDbContext>(provider => provider.GetService<StudentDbContext>());

//            return services;
//        }

//    }
//}
