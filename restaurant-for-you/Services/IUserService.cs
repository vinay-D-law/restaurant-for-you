using Gremlin.Net.Structure;
using LaYumba.Functional;
using restaurant_for_you.Domain;

namespace restaurant_for_you.Services
{
    public interface IUserService
    {
        public Option<UserCity> GetUserByEmailId();

        public Option<Edge> CreateUser(UserCity userCity);

        public Option<string> GetUserEmailFromToken();
    }
}
