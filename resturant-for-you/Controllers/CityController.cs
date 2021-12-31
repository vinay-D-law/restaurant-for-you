using Microsoft.AspNetCore.Mvc;
using resturant_for_you.Services;

namespace resturant_for_you.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService) => _cityService = cityService;

        /// <summary>
        /// Get All Cities List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllCities()
            => _cityService.GetAllCities()
                .Match(() => StatusCode(201, "No Citites Registerd"), _ => Ok(_));
    }
}
