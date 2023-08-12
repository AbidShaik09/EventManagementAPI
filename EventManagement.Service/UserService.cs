using EventManagement.Data.DTO;
using EventManagement.Data.Entities;
using EventManagement.Data.UnitOfWork;
using EventManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork) { 
        
            this.unitOfWork = unitOfWork;
        }
        public bool SignUp(UserSignUpDTO request)
        {
            var userEnitity = new User
            {
                Name = request.Name,
                Email = request.Email,
                IdCardNo = request.IdCardNo,
                Mobile = request.Mobile,
                Password = request.Password,
            };

            var user = unitOfWork.Users.Add(userEnitity);
            unitOfWork.Save();

            return user != null;
        }
    }
}
