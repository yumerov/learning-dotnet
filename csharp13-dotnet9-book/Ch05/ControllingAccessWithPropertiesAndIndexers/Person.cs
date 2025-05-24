namespace ControllingAccessWithPropertiesAndIndexers;

public class Person
{
    public string? Name;
    public readonly string HomePlanet = "Earth";
    public DateTimeOffset Born;

    #region Properties: Methods to get and/or set data or state.
    // A readonly property defined using C# 1 to 5 syntax.
    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}.",
                arg0: Name, arg1: HomePlanet);
        }
    }
    // Two readonly properties defined using C# 6 or later
    // lambda expression body syntax.
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - Born.Year;
    #endregion
    
    public string? FavoriteIceCream { get; set; }

    private string? _favoritePrimaryColor;
    public string? FavoritePrimaryColor
    {
        get => _favoritePrimaryColor;
        set
        {
            _favoritePrimaryColor = value?.ToLower() switch
            {
                "red" or "green" or "blue" => value,
                _ => throw new ArgumentException($"{value} is not a primary color. " + "Choose from: red, green, blue.")
            };
        }
    }

    private WondersOfTheAncientWorld _favoriteAncientWonder;
    public WondersOfTheAncientWorld FavoriteAncientWonder
    {
        get => _favoriteAncientWonder;
        set
        {
            string wonderName = value.ToString();
            if (wonderName.Contains(','))
            {
                throw new ArgumentException(
                    message: "Favorite ancient wonder can only have a single enum value.",
                    paramName: nameof(FavoriteAncientWonder));
            }
            
            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                    $"{value} is not a member of the WondersOfTheAncientWorld enum.",
                    paramName: nameof(FavoriteAncientWonder));
            }
            _favoriteAncientWonder = value;
        }
    }

}