using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using resturant_for_you.Domain;
using resturant_for_you.GremlinUtilities;
using LaYumba.Functional;

namespace resturant_for_you.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly GraphTraversalSource _g;

        public UserController(ILogger<UserController> logger, GraphTraversalSource g)
        {
            _logger = logger;
            _g = g;
        }

        [HttpGet]
        public UserCity Get(string emailId)
        {
            var user = _g.V().Has("user", "EmailId", emailId)
                .As("user").Out("situated_in")
                .As("city")
                .Select<object>("user", "city")
                .By(__.ValueMap<string, object>().By(__.Unfold<object>()))
                .By(__.ValueMap<string, object>().By(__.Unfold<object>())).Next();

            return JsonConvert.DeserializeObject<UserCity>(JsonConvert.SerializeObject(user));
        }

        [HttpPost]
        public IActionResult Post(UserCity userCity)
           => (from cityVertex in  userCity.City.GetCityVertex().Invoke(_g)
               from userVertex in CreateUser(userCity)
               select _g.AddE("situated_in").From(userVertex).To(cityVertex).Next())
                    .Match(() => StatusCode(500, "Internal Server Error"),
                    _ => Ok("User added successfully"));

        private Option<Vertex> CreateUser(UserCity userCity)
              => _g.AddV("user").Property("FirstName", userCity.User.FirstName)
                .Property("LastName", userCity.User.LastName)
                .Property("EmailId", userCity.User.EmailId).Next();

        [HttpDelete]
        public void RefreshDb()
        {
            _g.V().Drop().Iterate();
        }
    }
}
