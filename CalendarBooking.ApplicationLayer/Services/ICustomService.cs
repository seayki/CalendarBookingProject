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
        Task<Student?> FindById(int Id);
        void Insert(T entity);
        Task<T> Update(T entity);
        Task<IEnumerable<Student?>> Delete(int Id);
    }
}
