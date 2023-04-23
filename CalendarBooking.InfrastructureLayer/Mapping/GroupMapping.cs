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
    public class GroupMapping : Profile
    {
        public GroupMapping()
        {
            CreateMap<Group, GroupDTO>().MaxDepth(2);
        }
    }
}
