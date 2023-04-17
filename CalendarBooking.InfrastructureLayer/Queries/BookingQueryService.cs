using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Queries
{
    public class BookingQueryService : IBookingQueryService
    {
        private readonly DBContext _dbcontext;

        public BookingQueryService(DBContext dBContext)
        {

            _dbcontext = dBContext;
        }

        public async Task<int?> CountAsync()
        {
            return await _dbcontext.Bookings.CountAsync();
        }

        public async Task<IEnumerable<Booking>> GetAllAsync()
        {
            return await _dbcontext.Bookings.ToListAsync();
        }

        public async Task<Booking?> GetByIdAsync(int id)
        {
            return await _dbcontext.Bookings.FindAsync(id);
        }
    }
}
