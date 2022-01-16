using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using restaurant_for_you.Domain;
using restaurant_for_you.GremlinUtilities;
using System.Linq;

namespace restaurant_for_you.Services
{
    public class UserService : IUserService
    {
        readonly ICityService _cityService;
        readonly GraphTraversalSource _g;
        readonly HttpContext _httpContext;
        public UserService(ICityService cityService, GraphTraversalSource g, IHttpContextAccessor httpContextAccessor)
        {
            _cityService = cityService;
            _g = g;
            _httpContext = httpContextAccessor.HttpContext;
        }

        public Option<string> GetUserEmailFromToken()
            => _httpContext.User.Identities
                .First().Claims
                .Where(x => x.Type.Equals("https://example.com/email"))
                .Select(x => x.Value).FirstOrDefault();


        public Option<Edge> CreateUser(UserCity userCity)
            => from cityVertex in _cityService.GetVertexForACity(userCity.City)
               from userVertex in CreateUserVertex(userCity)
               from userCityEdge in _g.CreateEdge("situated_in", userVertex, cityVertex)
               select userCityEdge;

        public Option<UserCity> GetUserByEmailId()
           => from emailId in GetUserEmailFromToken()
              from user in _g.GetUserByEmailId(emailId)
              select JsonConvert.DeserializeObject<UserCity>(JsonConvert.SerializeObject(user));

        private Option<Vertex> CreateUserVertex(UserCity userCity)
           => _g.CreateUser(userCity);
    }
}
