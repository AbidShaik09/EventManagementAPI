using EventManagement.Data.DTO;
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
        [Route("")]
        [HttpPost]
        public HttpResponseMessage Register([FromBody] UserSignUpDTO user)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
