using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.ApplicationLayer.UnitOfWork;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public class TeacherCommandService : ITeacherCommandService
    {
        private readonly ITeacherRepo _teacherRepo;
        private readonly IUnitOfWork _unitOfWork;

        public TeacherCommandService(ITeacherRepo teacherRepo, IUnitOfWork unitOfWork)
        {
            _teacherRepo = teacherRepo;
            _unitOfWork = unitOfWork;
        }

        public Task Create(Teacher entity)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _teacherRepo.Create(entity);
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
                    _teacherRepo.Delete(id);
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

        public Task Update(Teacher entity, int id)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _teacherRepo.Update(entity, id);
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
