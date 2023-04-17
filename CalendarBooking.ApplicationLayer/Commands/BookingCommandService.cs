using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.ApplicationLayer.UnitOfWork;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public class BookingCommandService : IBookingCommandService
    {
        private readonly IBookingRepo _bookingRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookingDomainService _bookingDomainService;

        public BookingCommandService(IBookingRepo bookingRepo, IUnitOfWork unitOfWork, IBookingDomainService bookingDomainService)
        {
            _bookingRepo = bookingRepo;
            _unitOfWork = unitOfWork;
            _bookingDomainService = bookingDomainService;
        }
        public Task Create(Booking entity)
        {
            try
            {
                using (_unitOfWork)
                {
                _unitOfWork.CreateTransaction();
                 Booking booking = new Booking(_bookingDomainService, entity.TimeStart, entity.TimeEnd, entity.Student, entity.Timeslot);
                 _bookingRepo.Create(booking);
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
                _bookingRepo.Delete(id);
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
        public Task Update(Booking entity, int id)
        {
            try
            {
                using (_unitOfWork)
                {
                _unitOfWork.CreateTransaction();
                _bookingRepo.Update(entity, id);
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
