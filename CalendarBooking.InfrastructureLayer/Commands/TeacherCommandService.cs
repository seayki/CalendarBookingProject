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
    public class TeacherCommandService : ITeacherCommandService
    {
        private readonly DBContext _dbcontext;
        private readonly ITeacherDomainService _teacherDomainService;

        public TeacherCommandService(DBContext dbcontext, ITeacherDomainService teacherDomainService)
        {
            _dbcontext = dbcontext;
            _teacherDomainService = teacherDomainService;
        }

        public Task Create(Teacher entity) {
            throw new NotImplementedException();
        }

        public Task Delete(int id) {
            throw new NotImplementedException();
        }

        public Task Update(Teacher entity, int id) {
            throw new NotImplementedException();
        }
    }
}
