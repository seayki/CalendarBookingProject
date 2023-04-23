using AutoMapper;
using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Mapping
{
    public class TeacherMapping : Profile
    {
        public TeacherMapping()
        {
            CreateMap<Teacher, TeacherDTO>().MaxDepth(2);
        }
    }
}
