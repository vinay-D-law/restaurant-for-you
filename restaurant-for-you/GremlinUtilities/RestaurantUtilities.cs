using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using resturant_for_you.Domain;
using System.Collections.Generic;
using static LaYumba.Functional.F;

namespace resturant_for_you.GremlinUtilities
{
    public static class RestaurantUtilities
    {
        public static Option<IList<IDictionary<string, object>>> GetNearByResturantsForAUser(this GraphTraversalSource _g, string emailId)
        {
           var restaurantList = _g.V()
                .Has("user", "EmailId", emailId) // gremlin is in user vertex
                .Out("situated_in") // gremlin is in city vertex
                .As("address") // saving city details in this address key
                .In("situated_in") // gremlin is in both restaurant and user vertex
                .HasLabel("restaurant") // gremlin went to all restaurant vertex
                .Project<object>("Id","Name","Address") // select query of sql select id,name,address
                .By(T.Id) // for id -> send restaurant vertex id
                .By(__.Values<object>("Name")) // for id -> send restaurant vertex Name
                .By(__.Select<object>("address")
                      .By(__.ValueMap<string,object>()
                      .By(__.Unfold<object>()))) // here we take the saved address details and print them
                .ToList();

            return restaurantList?.Count > 0 ? Some(restaurantList): None;
        }

        public static Option<Vertex> CreateReview(this GraphTraversalSource _g, Review review)
            => _g.AddV("review").Property("Content", review.Content).Property("Rating", review.Rating).Next();

        public static Option<IList<IDictionary<string, object>>> GetReviewsForRestaurant(this GraphTraversalSource _g, int restaurantId)
        {
            var reviews = _g.V(restaurantId).As("restaurant")
                .In("about").As("review")
                .In("writes").As("user")
                .Project<object>("Id", "Content", "Rating", "User", "Restaurant")
                .By(__.Select<object>("review").By(T.Id))
                .By(__.Select<object>("review").By("Content"))
                .By(__.Select<object>("review").By("Rating"))
                .By(__.Select<object>("user").By(__.ValueMap<string, object>().By(__.Unfold<object>())))
                .By(__.Select<object>("restaurant").By(__.ValueMap<string, object>().By(__.Unfold<object>()))).ToList();

            return reviews?.Count > 0 ? Some(reviews) : None;
        }
    }
}
