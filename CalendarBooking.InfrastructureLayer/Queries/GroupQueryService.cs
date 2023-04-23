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
    public class GroupQueryService : IGroupQueryService
    {
        private readonly DBContext _dbcontext;
        private readonly IMapper _mapper;

        public GroupQueryService(DBContext dBContext, IMapper mapper)
        {

            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GroupDTO>> GetAllAsync()
        {
            var groups = _mapper.Map<IEnumerable<GroupDTO>>(await _dbcontext.Groups.ToListAsync());
            return groups;
        }

        public async Task<Group?> GetByIdAsync(int id)
        {
            return await _dbcontext.Groups.FindAsync(id);
        }
    }
}
