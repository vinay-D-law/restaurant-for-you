using Gremlin.Net.Structure;
using LaYumba.Functional;
using resturant_for_you.Domain;

namespace resturant_for_you.Services
{
    public interface IUserService
    {
        public Option<UserCity> GetUserByEmailId(string emailId);

        public Option<Edge> CreateUser(UserCity userCity);
    }
}
