using AutoMapper;
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
    public class UserQueryService : IUserQueryService
    {
        private readonly DBContext _dbcontext;
       

        public UserQueryService(DBContext dBContext)
        {

            _dbcontext = dBContext;
          
        }
        public async Task<User?> GetByUsername(string userName)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(u => u.UserName == userName);
        }
    }
}
