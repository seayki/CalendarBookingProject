using AutoMapper;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.Queries.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Mapping
{
    public class StudentBooking : Profile
    {
        public StudentBooking() 
        {
            CreateMap<Student, StudentDTO>().MaxDepth(2);
            CreateMap<Booking, BookingDTO>().PreserveReferences();
        }
    }
}
