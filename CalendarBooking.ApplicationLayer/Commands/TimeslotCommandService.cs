using CalendarBooking.ApplicationLayer.Queries;
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
    public class TimeslotCommandService : ITimeslotCommandService
    {
        private readonly ITimeslotRepo _timeslotRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITimeslotDomainService _timeslotDomainService;
        private readonly ITeacherQueryService _teacherQueryService;
        private readonly ICalendarQueryService _calendarQueryService;

        public TimeslotCommandService(ITimeslotRepo timeslotRepo, IUnitOfWork unitOfWork, ITimeslotDomainService timeslotDomainService, ITeacherQueryService teacherQueryService, ICalendarQueryService calendarQueryService)
        {
            _timeslotDomainService = timeslotDomainService;
            _timeslotRepo = timeslotRepo;
            _unitOfWork = unitOfWork;
            _teacherQueryService = teacherQueryService;
            _calendarQueryService = calendarQueryService;
        }

        public Task Create(DateTime timeStart, DateTime timeEnd, int teacherId, int calendarId)
        {
            try
            {
                Teacher? teacher =  _teacherQueryService.GetById(teacherId);
                Calendar? calendar = _calendarQueryService.GetById(calendarId);
                if (teacher != null && calendar != null)
                { 
                    using (_unitOfWork)
                    {
                        _unitOfWork.CreateTransaction();                    
                        Timeslot timeslot = new Timeslot(_timeslotDomainService, timeStart, timeEnd, teacher, calendar);
                        _timeslotRepo.Create(timeslot);
                        _unitOfWork.Save();
                        _unitOfWork.Commit();
                        return Task.CompletedTask;
                    }
                }
                throw new ArgumentException("Calendar or teacher could not be found.");
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
                    _timeslotRepo.Delete(id);
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

