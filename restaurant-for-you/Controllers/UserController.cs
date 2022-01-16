using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurant_for_you.Domain;
using System.Linq;
using restaurant_for_you.Services;
using resturant_for_you.Domain;

namespace restaurant_for_you.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IRestaurantService _restaurantService;

        public UserController(ILogger<UserController> logger, IUserService userService
            , IRestaurantService restaurantService)
        {
            _logger = logger;
            _userService = userService;
            _restaurantService = restaurantService;
        }

        [HttpGet]
        public IActionResult Get()
            => _userService.GetUserByEmailId()
                .Match(() => StatusCode(404, "User not found"), _ => Ok(_));

        [HttpGet]
        [Route("restaurants")]
        public IActionResult GetResturantsNearBy()
            => _restaurantService.GetNearByRestaurants()
            .Match(() => StatusCode(404, "No Restaurants in the area currently"), _ => Ok(_));


        [HttpGet]
        [Route("restaurant/reviews")]
        public IActionResult GetResturantsNearBy(int restaurantId)
            => _restaurantService.GetAllReviewsForResturant(restaurantId)
            .Match(() => StatusCode(404, "No Reviews Given Yet"), _ => Ok(_));


        [HttpPost]
        [Route("restaurant/review")]
        public IActionResult Post(Review review)
           => _restaurantService.WriteReview(review)
                .Match(() => StatusCode(500, "Input Data was wrong"), _ => Ok(_));



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
