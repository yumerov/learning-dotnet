namespace Packt.Shared;

public class Person : object
{
    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = [];
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

}