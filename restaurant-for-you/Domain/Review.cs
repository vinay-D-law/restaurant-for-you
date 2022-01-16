using restaurant_for_you.Domain;

namespace resturant_for_you.Domain
{
    public record Review(string Content,int Rating, int RestaurantId);
    public record ReviewDetails(int Id, string Content, int Rating, User User, Restaurant Restaurant);
}
