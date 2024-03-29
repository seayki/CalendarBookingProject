﻿using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.ReposatoryServices;
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
    public class GroupRepo : IGroupRepo
    {

        private readonly DBContext _dbcontext;

        public GroupRepo(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Create(Group group)
        {
            _dbcontext.Groups.Add(group);        
        }

        public void Delete(int id)
        {
            var group = _dbcontext.Groups.Find(id);
            if (group != null)
            {
                _dbcontext.Groups.Remove(group);
            }
        }

        public void Update(string name, int id)
        {
            var group = _dbcontext.Groups.Find(id);
            if (group != null)
            {
                group.Name = name;
            }
        }
    }
}
