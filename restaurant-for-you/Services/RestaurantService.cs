using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using LaYumba.Functional;
using restaurant_for_you.Domain;
using restaurant_for_you.GremlinUtilities;
using resturant_for_you.Domain;
using resturant_for_you.GremlinUtilities;
using System.Collections.Generic;
using System.Linq;

namespace restaurant_for_you.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly GraphTraversalSource _g;
        private readonly IUserService _userService;

        public RestaurantService(GraphTraversalSource g, IUserService userService)
        {
            _g = g;
            _userService = userService;
        }

        public Option<Vertex> GetAllReviewsForResturant(int restaurantId)
        {
            throw new System.NotImplementedException();
        }

        public Option<List<Restaurant>> GetNearByRestaurants()
            => from emailId in _userService.GetUserEmailFromToken()
               from restaurants in _g.GetNearByResturantsForAUser(emailId)
               select restaurants.Convert<List<Restaurant>>();

        public Option<Vertex> WriteReview(Review review)
            => from reviewVertex in _g.CreateReview(review)
               from emailId in _userService.GetUserEmailFromToken()
               from user in _g.GetVertex("user", "EmailId", emailId)
               from restaurant in _g.GetVertex(review.RestaurantId)
               from userReview in _g.CreateEdge("writes", user, reviewVertex)
               from aboutResturant in _g.CreateEdge("about", reviewVertex, restaurant)
               select reviewVertex;

        Option<List<ReviewDetails>> IRestaurantService.GetAllReviewsForResturant(int restaurantId)
            => from reviewList in _g.GetReviewsForRestaurant(restaurantId)
               select reviewList.Convert<List<ReviewDetails>>();

    }

}