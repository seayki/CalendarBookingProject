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

        public TimeslotCommandService(ITimeslotRepo timeslotRepo, IUnitOfWork unitOfWork, ITimeslotDomainService timeslotDomainService)
        {
            _timeslotDomainService = timeslotDomainService;
            _timeslotRepo = timeslotRepo;
            _unitOfWork = unitOfWork;
        }

        public Task Create(Timeslot entity)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    Timeslot timeslot = new Timeslot(_timeslotDomainService, entity.TimeStart, entity.TimeEnd, entity.Teacher);
                    _timeslotRepo.Create(timeslot);
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

        public Task Update(Timeslot entity, int id)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _timeslotRepo.Update(entity, id);
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

