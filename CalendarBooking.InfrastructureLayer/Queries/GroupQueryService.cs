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

        public GroupQueryService(DBContext dBContext)
        {

            _dbcontext = dBContext;
        }

        public async Task<int?> CountAsync()
        {
            return await _dbcontext.Groups.CountAsync();
        }

        public async Task<IEnumerable<Group>> GetAllAsync()
        {
            return await _dbcontext.Groups.ToListAsync();
        }

        public async Task<Group?> GetByIdAsync(int id)
        {
            return await _dbcontext.Groups.FindAsync(id);
        }
    }
}
