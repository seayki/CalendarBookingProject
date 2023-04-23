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
    public class CalendarQueryService : ICalendarQueryService
    {
        private readonly DBContext _dbcontext;
        private readonly IMapper _mapper;

        public CalendarQueryService(DBContext dBContext, IMapper mapper)
        {

            _dbcontext = dBContext;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<CalendarDTO>> GetAllAsync()
        {
            var calendars = _mapper.Map<IEnumerable<CalendarDTO>>(await _dbcontext.Calendars.ToListAsync());
            return calendars;
        }

        public async Task<Calendar?> GetByIdAsync(int id)
        {
            return await _dbcontext.Calendars.FindAsync(id);
        }

        public Calendar? GetById(int id)
        {
            return _dbcontext.Calendars.Find(id);
        }
    }
}
