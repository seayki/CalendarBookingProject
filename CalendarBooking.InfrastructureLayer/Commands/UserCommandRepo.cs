using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class UserRepo : IUserRepo
    {
        private readonly DBContext _dbcontext;
        public UserRepo(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void Create(User user)
        {          
            _dbcontext.Users.Add(user);          
        }
    }
}
