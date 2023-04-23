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
    public class TeacherQueryService : ITeacherQueryService
    {

        private readonly DBContext _dbcontext;
        private readonly IMapper _mapper;

        public TeacherQueryService(DBContext dBContext, IMapper mapper)
        {

            _dbcontext = dBContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TeacherDTO>> GetAllAsync()
        {
            var teachers = _mapper.Map<IEnumerable<TeacherDTO>>(await _dbcontext.Teachers.ToListAsync());
            return teachers;
        }

        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await _dbcontext.Teachers.FindAsync(id);
        }

        public Teacher? GetById(int id)
        {
            return _dbcontext.Teachers.Find(id);
        }
    }
}
