using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.ApplicationLayer.UnitOfWork;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public class CalendarCommandService : ICalendarCommandService
    {
        private readonly ICalendarRepo _calendarRepo;
        private readonly IUnitOfWork _unitOfWork;
     

        public CalendarCommandService(ICalendarRepo calendarRepo, IUnitOfWork unitOfWork)
        {
            _calendarRepo = calendarRepo;
            _unitOfWork = unitOfWork;
           
        }
        public Task Create(string name)
        {

            try
            {

            
            using (_unitOfWork)
            {
                _unitOfWork.CreateTransaction();
                _calendarRepo.Create(name);
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Task.CompletedTask;
            }
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
}
        public Task Delete(int id)
        {
            try
            {

                using (_unitOfWork)
            {
                _unitOfWork.CreateTransaction();
                _calendarRepo.Delete(id);
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Task.CompletedTask;
            }
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }
        public Task Update(string name, int id)
        {

            try
            {  
            using (_unitOfWork)
            {
                _unitOfWork.CreateTransaction();
                _calendarRepo.Update(name, id);
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Task.CompletedTask;
            }
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }
    }
}
