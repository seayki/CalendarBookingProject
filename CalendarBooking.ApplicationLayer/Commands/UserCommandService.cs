﻿using BCrypt.Net;
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
using System.Xml.Linq;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public class UserCommandService : IUserCommandService
    {
        private readonly IUserRepo _userRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserDomainService _userDomainService;

        public UserCommandService(IUserRepo userRepo, IUnitOfWork unitOfWork, IUserDomainService userDomainService)
        {
            
            _userRepo = userRepo;
            _unitOfWork = unitOfWork;
            _userDomainService = userDomainService;
        }
        public Task Create(UserDTO user)
        {
            try
            {
                using (_unitOfWork)
                {
                    User _user = new User(user.Username, user.Password, _userDomainService); 
                    _unitOfWork.CreateTransaction();
                    _userRepo.Create(_user);
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
