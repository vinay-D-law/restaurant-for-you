using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using Newtonsoft.Json;
using resturant_for_you.Domain;
using resturant_for_you.GremlinUtilities;

namespace resturant_for_you.Services
{
    public class UserService : IUserService
    {
        readonly ICityService _cityService;
        readonly GraphTraversalSource _g;
        public UserService(ICityService cityService, GraphTraversalSource g)
        {
            _cityService = cityService;
            _g = g;
        }
        public Option<Edge> CreateUser(UserCity userCity)
            => from cityVertex in _cityService.GetVertexForACity(userCity.City)
               from userVertex in CreateUserVertex(userCity)
               from userCityEdge in _g.CreateEdge("situated_in",userVertex,cityVertex)
               select userCityEdge;

        public Option<UserCity> GetUserByEmailId(string emailId)
           => (from user in _g.GetUserByEmailId(emailId)
              select JsonConvert.DeserializeObject<UserCity>(JsonConvert.SerializeObject(user)));

        private Option<Vertex> CreateUserVertex(UserCity userCity)
           => _g.CreateUser(userCity);
    }
}
