﻿using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.InfrastructureLayer.Data;
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

        public TeacherQueryService(DBContext dBContext)
        {

            _dbcontext = dBContext;
        }
    }
}
