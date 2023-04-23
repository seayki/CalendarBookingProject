using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.ApplicationLayer.Queries;
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
        private readonly ITimeslotQueryService _timeslotQueryService;
        private readonly IStudentQueryService _studentQueryService;
        public BookingCommandService(IBookingRepo bookingRepo, IUnitOfWork unitOfWork, IBookingDomainService bookingDomainService, ITimeslotQueryService timeslotQueryService, IStudentQueryService studentQueryService)
        {
            _bookingRepo = bookingRepo;
            _unitOfWork = unitOfWork;
            _bookingDomainService = bookingDomainService;
            _timeslotQueryService = timeslotQueryService;
            _studentQueryService = studentQueryService;
        }

        public Task Create(CreateBookingDTO createBookingDTO)
        {
            try
            {
                Timeslot? timeslot = _timeslotQueryService.GetById(createBookingDTO.timeslotID);
                Student? student = _studentQueryService.GetById(createBookingDTO.studentID);
                if (student != null && timeslot != null)
                {
                    using (_unitOfWork)
                    {
                        _unitOfWork.CreateTransaction();
                         Booking booking = new Booking(_bookingDomainService, createBookingDTO.TimeStart, createBookingDTO.TimeEnd, student, timeslot);
                         _bookingRepo.Create(booking);
                        _unitOfWork.Save();
                        _unitOfWork.Commit();
                        return Task.CompletedTask;
                    }
                }
                throw new ArgumentException("Timeslot or student could not be found.");
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
        public Task UpdateTimeStart(DateTime dateTime, int id)
        {
            try
            {
                using (_unitOfWork)
                {
                _unitOfWork.CreateTransaction();
                Booking booking = _bookingRepo.UpdateTimeStart(dateTime, id);
                booking.Validate();
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
