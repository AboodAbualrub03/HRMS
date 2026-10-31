using BCrypt.Net;
using HRMS.DbContexts;
using HRMS.Dtos.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly HRMSContext _context;
      

        public AuthController(HRMSContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(LoginDto loginDto)
        {

            var user = _context.Users.FirstOrDefault(x=>x.Username.ToUpper() == loginDto.Username.ToUpper());
            if(user == null )
            {
                return Unauthorized(new Exception("Invalid Username Or Password"));

            }

            
            if(!BCrypt.Net.BCrypt.Verify(loginDto.Password,user.HashedPassword))
            {
                return Unauthorized(new Exception("Invalid Username Or Password"));
            }


            //Generate Token 



            return Ok();






        }


    }
}
