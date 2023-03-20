using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Services
{
    public interface ICustomService<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T?> FindById(int Id);
       
        Task Delete(int Id);
       
        Task Insert(T entity);

    }
}
