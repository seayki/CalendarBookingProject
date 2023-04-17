using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.ApplicationLayer.UnitOfWork;
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
    public class BookingRepo : IBookingRepo
    {
        private readonly DBContext _dbcontext;
        public BookingRepo(DBContext dbcontext)
        {
            _dbcontext = dbcontext;    
        }

        public void Create(Booking entity)
        {
            _dbcontext.Bookings.Add(entity);
        }
        public void Delete(int id)
        {
            var booking = _dbcontext.Bookings.Find(id);
            if (booking != null) 
            {
                _dbcontext.Bookings.Remove(booking);
            }
        }

        public void Update(Booking entity, int id)
        {
            var booking = _dbcontext.Bookings.Find(id);
            if (booking != null) 
            {
                
                booking.Student = entity.Student;
                booking.TimeStart = entity.TimeStart;
                booking.TimeEnd = entity.TimeEnd;
                booking.Timeslot = entity.Timeslot;
            }
            
        }            
    }
}
