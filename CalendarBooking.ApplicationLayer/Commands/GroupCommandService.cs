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
    public class GroupCommandService : IGroupCommandService
    {
        private readonly IGroupRepo _groupRepo;
        private readonly IUnitOfWork _unitOfWork;


        public GroupCommandService(IGroupRepo groupRepo, IUnitOfWork unitOfWork)
        {
            _groupRepo = groupRepo;
            _unitOfWork = unitOfWork;

        }
        public Task Create(Group entity)
        {

            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _groupRepo.Create(entity);
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
                    _groupRepo.Delete(id);
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
        public Task Update(Group entity, int id)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CreateTransaction();
                    _groupRepo.Update(entity, id);
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
