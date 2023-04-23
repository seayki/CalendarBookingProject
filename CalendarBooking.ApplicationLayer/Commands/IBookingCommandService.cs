using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface IBookingCommandService
    {
        Task Delete(int id);

        Task UpdateTimeStart(DateTime dateTime, int id);

        Task Create(CreateBookingDTO createBookingDTO);

    }
}
