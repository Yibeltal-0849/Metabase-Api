using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XOKA.WebUI.Model;
using XOKA.WebUI.Repos;
namespace XOKA.WebUI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJWTRepos jWTRepos;
        public UserController(IJWTRepos jWTRepos)
        {
            this.jWTRepos = jWTRepos;
        }
        [HttpGet]
        [Route("userList")]
        public List<string> Get()
        {
            var users = new List<string>
            {
                "daniel Worku",
                "yared Tegegn",
                "belay beru"
            };
            return users;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult authenticate(JwtUsers userdata)
        {
            var Token = jWTRepos.Authenticate(userdata);

            if (Token == null)
            {
                return Unauthorized();
            }
            return Ok(Token);
        }
    }
}
