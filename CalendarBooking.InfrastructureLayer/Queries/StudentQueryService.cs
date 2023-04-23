using AutoMapper;
using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Queries
{
    public class StudentQueryService : IStudentQueryService 
    {
        private readonly DBContext _dbcontext;
        private readonly IMapper _mapper;

        public StudentQueryService(DBContext dBContext, IMapper mapper)
        {           
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StudentDTO>> GetAllAsync()
        {
            var students = _mapper.Map<IEnumerable<StudentDTO>>(await _dbcontext.Students.ToListAsync());
            return students;
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _dbcontext.Students.FindAsync(id);
        }

        public Student? GetById(int id)
        {
            return  _dbcontext.Students.Find(id);
        }
    }
}
