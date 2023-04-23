using CalendarBooking.ApplicationLayer.DTO;
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

        public Task Create(CreateTeacherDTO createTeacherDTO)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    User user = new User(createTeacherDTO.UserName, createTeacherDTO.Password);
                    Teacher teacher = new Teacher(createTeacherDTO.FirstName, createTeacherDTO.LastName, user);    
                    _teacherRepo.Create(teacher);
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

        public Task UpdateFirstName(string firstName, int id)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _teacherRepo.UpdateFirstName(firstName, id);
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

        public Task UpdateLastName(string lastName, int id)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _teacherRepo.UpdateLastName(lastName, id);
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
