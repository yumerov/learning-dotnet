using Packt.Shared;

ConfigureConsole();

Person bob = new()
{
    Name = "Bob Smith",
    Born = new DateTimeOffset(
        year: 1965, month: 12, day: 22,
        hour: 16, minute: 28, second: 0,
        offset: TimeSpan.FromHours(-5)), // US Eastern Standard Time.
    BucketList =
        WondersOfTheAncientWorld.HangingGardensOfBabylon
        | WondersOfTheAncientWorld.MausoleumAtHalicarnassus
};

WriteLine($"{bob.Name} is a {Person.Species}.");
WriteLine(format: "{0} was born on {1:D}.", arg0: bob.Name, arg1: bob.Born);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

bob.Children.Add(new Person { Name = "Alfred Bobson" });
bob.Children.Add(new Person { Name = "John Bobson" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new()
{
    AccountName = "Mrs. Jones",
    Balance = 2400
};
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new()
{
    AccountName = "Ms. Gerrier",
    Balance = 98
};
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

Person blankPerson = new();
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

WriteLine("Modern:");
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
WriteLine("{0}: {1} written by {2} has {3:N0} pages.", book.Isbn, book.Title, book.Author, book.PageCount);


WriteLine("Methods:");
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHelloTo("Emily"));

WriteLine(bob.OptionalParameters());
WriteLine(bob.OptionalParameters("Jump!", 98.5));
WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));


// An array containing a mix of passenger types.
Passanger[] passengers = [
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKg = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKg = 0, Name = "Amit" }
];
foreach (Passanger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger { AirMiles: > 35_000 } => 1_500M, // dotnet 9
        FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M, // dotnet 8
        FirstClassPassenger _                         => 2_000M,
        BusinessClassPassenger _                      => 1_000M,
        CoachClassPassenger p when p.CarryOnKg < 10.0 => 500M,
        CoachClassPassenger _                         => 650M,
        _                                             => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}
