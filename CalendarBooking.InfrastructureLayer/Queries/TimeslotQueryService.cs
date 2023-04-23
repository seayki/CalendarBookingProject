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
    public class TimeslotQueryService : ITimeslotQueryService
    {
        private readonly DBContext _dbcontext;
        private readonly IMapper _mapper;

        public TimeslotQueryService(DBContext dBContext, IMapper mapper)
        {

            _dbcontext = dBContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TimeslotDTO>> GetAllAsync()
        {
            var timeslots = _mapper.Map<IEnumerable<TimeslotDTO>>(await _dbcontext.Timeslots.ToListAsync());
            return timeslots;
        }

        public async Task<Timeslot?> GetByIdAsync(int id)
        {
            return await _dbcontext.Timeslots.FindAsync(id);
        }

        public Timeslot? GetById(int id)
        {
            return _dbcontext.Timeslots.Find(id);
        }
    }
}
