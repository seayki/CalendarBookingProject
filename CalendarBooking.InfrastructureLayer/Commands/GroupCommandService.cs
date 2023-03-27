using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class GroupCommandService : IGroupCommandService
    {

        private readonly DBContext _dbcontext;
        private readonly IGroupDomainService _groupDomainService;

        public GroupCommandService(DBContext dbcontext, IGroupDomainService groupDomainService)
        {
            _dbcontext = dbcontext;
            _groupDomainService = groupDomainService;
        }

        public Task Create(Group entity) {
            throw new NotImplementedException();
        }

        public Task Delete(int id) {
            throw new NotImplementedException();
        }

        public Task Update(Group entity, int id) {
            throw new NotImplementedException();
        }
    }
}
