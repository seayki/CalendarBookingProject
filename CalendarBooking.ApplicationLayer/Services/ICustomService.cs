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
        void FindById(int Id);
        void Insert(T entity);
        Task<T> Update(T entity);
        void Delete(T entity);
    }
}
