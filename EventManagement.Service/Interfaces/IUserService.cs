using EventManagement.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Service.Interfaces
{
    public interface IUserService
    {
        bool SignUp(UserSignUpDTO request);
    }
}
