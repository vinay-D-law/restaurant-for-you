using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using resturant_for_you.Domain;
using System.Collections.Generic;
using static LaYumba.Functional.F;

namespace resturant_for_you.GremlinUtilities
{
    public static class UserUtilities
    {
        public static Option<IDictionary<string, object>> GetUserByEmailId(this GraphTraversalSource _g, string emailId)
        { 
            var userData = _g.V().Has("user", "EmailId", emailId)
                .As("user")
                .Out("situated_in")
                .As("city")
                .Select<object>("user", "city")
                .By(__.ValueMap<string, object>().By(__.Unfold<object>()))
                .By(__.ValueMap<string, object>().By(__.Unfold<object>())).Next();
             
            return userData == null ?  None :  Some(userData);
        }

        public static Option<Vertex> CreateUser(this GraphTraversalSource _g, UserCity userCity)
            => _g.AddV("user").Property("FirstName", userCity.User.FirstName)
                 .Property("LastName", userCity.User.LastName)
                 .Property("EmailId", userCity.User.EmailId).Next();

    }
}
