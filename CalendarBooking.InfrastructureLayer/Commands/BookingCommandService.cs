using CalendarBooking.ApplicationLayer.Commands;
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

        public BookingCommandService(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Booking?> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> Update(Booking entity, int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking?> CreateBooking(DateTime timeStart, DateTime timeEnd, Student student, Teacher teacher, Timeslot timeslot)
        {
            using var transaction = _dbcontext.Database.
            BeginTransaction(IsolationLevel.Serializable);
            try
            {
                var Booking = new Booking
                {
                    Student = student,
                    TimeStart = timeStart,
                    TimeEnd = timeEnd,
                    Teacher = teacher, 
                    Timeslot = timeslot
                };
                _dbcontext.Bookings.Add(Booking);
                _dbcontext.SaveChanges();
                await transaction.CommitAsync();
                return Booking;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                transaction.Rollback();
                return null;
            }
        }
        
            
    }
}
