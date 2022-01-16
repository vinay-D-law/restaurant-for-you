namespace restaurant_for_you.Domain
{
    public record User(string FirstName, string LastName, string EmailId);

    public record UserCity(User User, City City);
}
