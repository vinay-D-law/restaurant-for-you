using Gremlin.Net.Structure;
using LaYumba.Functional;
using restaurant_for_you.Domain;
using resturant_for_you.Domain;
using System.Collections.Generic;

namespace restaurant_for_you.Services
{
    public interface IRestaurantService
    {
        public Option<List<Restaurant>> GetNearByRestaurants();

        public Option<Vertex> WriteReview(Review review);

        public Option<List<ReviewDetails>> GetAllReviewsForResturant(int restaurantId);
    }
}
