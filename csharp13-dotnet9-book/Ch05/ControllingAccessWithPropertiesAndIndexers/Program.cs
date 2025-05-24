using ControllingAccessWithPropertiesAndIndexers;
using static System.Console;

Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
string color = "Red";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}",
        nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

try
{
    sam.FavoritePrimaryColor = "black";
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}", nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

try
{
    sam.FavoriteAncientWonder =
        WondersOfTheAncientWorld.StatueOfZeusAtOlympia |
        WondersOfTheAncientWorld.GreatPyramidOfGiza;
}
catch (ArgumentException ex)
{
    Write(ex.Message);
}