using CalendarBooking.ApplicationLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface IUserCommandService
    {
        Task Create(UserDTO user);
    }
}
