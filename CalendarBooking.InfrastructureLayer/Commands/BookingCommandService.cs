using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class BookingCommandService : IBookingCommandService
    {
        private readonly DBContext _dbcontext;
        private readonly IBookingDomainService _domainService;

        public BookingCommandService(DBContext dbcontext, IBookingDomainService domainService)
        {
            _dbcontext = dbcontext;
            _domainService = domainService;
        }

        public async Task Delete(int id)
        {
            var booking = _dbcontext.Bookings.Find(id);
            _dbcontext.Bookings.Remove(booking);
        }

        public async Task Update(Booking entity, int id)
        {
            var booking = _dbcontext.Bookings.Find(id);
            if (booking != null) 
            {
                booking.Teacher = entity.Teacher;
                booking.Student = entity.Student;
                booking.TimeStart = entity.TimeStart;
                booking.TimeEnd = entity.TimeEnd;
                booking.Time = entity.Time;
                
            }
            
        }

        public async Task Create(Booking entity)
        {
            var Booking = new Booking(_domainService, entity.TimeStart, entity.TimeEnd, entity.Student) {

            };
        
        }
        
            
    }
}
