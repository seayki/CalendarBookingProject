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
    public class StudentCommandService : IStudentCommandService
    {
        private readonly IStudentRepo _studentRepo;
        private readonly IUnitOfWork _unitOfWork;


        public StudentCommandService(IStudentRepo studentRepo, IUnitOfWork unitOfWork)
        {
            _studentRepo = studentRepo;
            _unitOfWork = unitOfWork;

        }
        public Task Create(string firstName, string lastName)
        {

            try
            {


                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _studentRepo.Create(firstName, lastName);
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
        public Task Update(Student entity, int id)
        {

            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _studentRepo.Update(entity, id);
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
