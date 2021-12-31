using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using resturant_for_you.Domain;
using resturant_for_you.Services;

namespace resturant_for_you.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get(string emailId)
        {
            var user = HttpContext.User.Identity.Name;

            return _userService.GetUserByEmailId(emailId)
                .Match(() => StatusCode(404, "User not found"), _ => Ok(_));
        }

        [HttpPost]
        public IActionResult Post(UserCity userCity)
           => _userService.CreateUser(userCity)
                .Match(() => StatusCode(500, "Input Data was wrong"), _ => Ok("User Created Successfully"));



        [HttpDelete]
        public void RefreshDb()
        {
           // _g.V().Drop().Iterate();
        }
    }
}
