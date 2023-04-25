using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.DomainServices
{
    public class UserDomainService : IUserDomainService
    {
        private readonly DBContext _dbContext;

        public UserDomainService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public bool IsUserNameUnique(string userName)
        {
            if (_dbContext.Users.Any(u => u.UserName == userName)) { return false; }
            return true;        
        }
    }
}
