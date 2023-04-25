using CalendarBooking.ApplicationLayer.DTO;
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
    public class StudentCommandService : IStudentCommandService
    {
        private readonly IStudentRepo _studentRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserDomainService _userDomainService;

        public StudentCommandService(IStudentRepo studentRepo, IUnitOfWork unitOfWork, IUserDomainService userDomainService)
        {
            _studentRepo = studentRepo;
            _unitOfWork = unitOfWork;
            _userDomainService = userDomainService;
        }
        public Task Create(CreateStudentDTO createStudentDTO)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    User user = new User(createStudentDTO.UserName, createStudentDTO.Password, _userDomainService);
                    Student student = new Student(createStudentDTO.FirstName, createStudentDTO.LastName, user);
                    _studentRepo.Create(student);
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
                    _studentRepo.Delete(id);
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
        public Task UpdateEmail(string email, int id)
        {

            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _studentRepo.UpdateEmail(email, id);
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
                    _studentRepo.UpdateFirstName(firstName, id);
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
                    _studentRepo.UpdateLastName(lastName, id);
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
