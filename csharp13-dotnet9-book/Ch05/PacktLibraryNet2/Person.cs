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

    public void WriteToConsole()
    {
        Console.WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }
    
    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHelloTo(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string OptionalParameters(string command = "Run!",
        double number = 0.0, bool active = true)
    {
        return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
    }
}