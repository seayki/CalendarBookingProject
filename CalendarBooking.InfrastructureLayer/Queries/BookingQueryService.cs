using AutoMapper;
using CalendarBooking.ApplicationLayer.DTO;
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
        private readonly IMapper _mapper;

        public BookingQueryService(DBContext dBContext, IMapper mapper)
        {

            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookingDTO>> GetAllAsync()
        {
            var bookings = _mapper.Map<IEnumerable<BookingDTO>>(await _dbcontext.Bookings.ToListAsync());
            return bookings;
        }

        public async Task<Booking?> GetByIdAsync(int id)
        {
            return await _dbcontext.Bookings.FindAsync(id);
        }
    }
}
