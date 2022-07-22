namespace CoffeeShopRegistrationLab.Models
{
    public class CoffeeMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Vegan { get; set; }
        public string FavDrink { get; set; }

        //ASP Does not like constructors
    }
}
