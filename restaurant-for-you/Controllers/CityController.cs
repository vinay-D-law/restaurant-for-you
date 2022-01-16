using Microsoft.AspNetCore.Mvc;
using restaurant_for_you.Services;

namespace restaurant_for_you.Controllers
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
                .Match(() => StatusCode(201, "No Cities Registered"), Ok);
    }
}
