using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;

namespace CalendarBooking.InfrastructureLayer.Mapping
{
    public class StudentMapping : Profile
    {
        public StudentMapping()
        {
            CreateMap<Student, StudentDTO>().MaxDepth(2);
        }
    }
}
