using EventManagement.Data.DTO;
using EventManagement.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly IUserService  userService;
        public SignUpController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("")]
        [HttpPost]
        public HttpResponseMessage Register([FromBody] UserSignUpDTO user)
        {
            if(this.userService.SignUp(user))
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
    }
}
