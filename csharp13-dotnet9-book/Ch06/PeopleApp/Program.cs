﻿// See https://aka.ms/new-console-template for more information

using Packt.Shared;

Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2001, month: 3, day: 25,
        hour: 0, minute: 0, second: 0,
        offset: TimeSpan.Zero)
};
harry.WriteToConsole();

// Statics
Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);
Person.Marry(lamech, zillah);
lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

var baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");


var baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";
adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();
for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine(format: "  {0}'s child #{1} is named \"{2}\".",
        arg0: lamech.Name, arg1: i,
        arg2: lamech.Children[i].Name);
}


try
{
    if (lamech + zillah)
    {
        WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
    }
}
catch (Exception e)
{
    WriteLine($"Error: {e.Message}");
}


var baby3 = lamech * adah;
baby3.Name = "Jubal";
var baby4 = zillah * lamech;
baby4.Name = "Naamah";
lamech.WriteChildrenToConsole();

Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};

WriteLine("Initial list of people:");
foreach (var person in people) WriteLine(person is null ? "null person" : person.Name ?? "null name");
Array.Sort(people);
Write("After sorting using Person's IComparable implementation:");
foreach (var person in people) WriteLine(person is null ? "null person" : person.Name ?? "null name");

WriteLine("[Comparing objects using a separate class] Initial list of people:");
foreach (var person in people) WriteLine(person is null ? "null person" : person.Name ?? "null name");
Array.Sort(people, new PersonComparer());
Write("[Comparing objects using a separate class] After sorting using Person's IComparable implementation:");
foreach (var person in people) WriteLine(person is null ? "null person" : person.Name ?? "null name");

Human human = new();
human.Lose();
((IGamePlayer)human).Lose();
IGamePlayer gamePlayer = human;
gamePlayer.Lose();

var player = new DvdPlayer();
player.Play();
player.Pause();
((IPlayable)player).Stop();

int? nullableInt = null;
Nullable<int> nullableInt2 = null;
WriteLine($"int? -> value: {nullableInt}; default: {nullableInt.GetValueOrDefault()}");
WriteLine($"Nullable<int> -> value: {nullableInt2}; default: {nullableInt2.GetValueOrDefault()}");

Address address = new(city: "London")
{
    Building = null,
    Street = null!,
    Region = "UK"
};
WriteLine($"building length: {address.Building?.Length}");
if (address.Street is not null)
{
    WriteLine(address.Street.Length);
}

try
{
    string? nullableString = null;
    ArgumentNullException.ThrowIfNull(nullableString);
}
catch (ArgumentNullException exception)
{
    WriteLine($"exception: {exception.Message}");
}

Employee john = new()
{
    Name = "John Jones",
    Born = new DateTimeOffset(year: 1990, month: 7, day: 28,
        hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};
john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
john.WriteToConsole();
WriteLine($"john: {john.ToString()}");

Employee aliceInEmployee = new() { Name = "Alice", EmployeeCode = "AA123" };
Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());


Employee explicitAlice = (Employee)aliceInPerson;
if (aliceInPerson is Employee explicitAlice2)
{
    WriteLine($"{nameof(explicitAlice2)} is an Employee.");
}

Employee? aliceAsEmployee = aliceInPerson as Employee;
if (aliceAsEmployee is not null)
{
    WriteLine($"{nameof(aliceInPerson)} as an Employee.");
}

try
{
    john.TimeTravel(when: new(1999, 12, 31));
    john.TimeTravel(when: new(1950, 12, 25));
}
catch (PersonException ex)
{
    WriteLine(ex.Message);
}

const string email1 = "pamela@test.com";
const string email2 = "ian&test.com";
WriteLine("{0} is a valid e-mail address: {1}",
    arg0: email1,
    arg1: email1.IsValidEmail());
WriteLine("{0} is a valid e-mail address: {1}",
    arg0: email2,
    arg1: email2.IsValidEmail());

C1 c1 = new() { Name = "Bob" };
c1.Name = "Bill";
C2 c2 = new(Name: "Bob");
// c2.Name = "Bill"; // CS8852: Init-only property.
S1 s1 = new() { Name = "Bob" };
s1.Name = "Bill";
S2 s2 = new(Name: "Bob");
s2.Name = "Bill";
S3 s3 = new(Name: "Bob");
// s3.Name = "Bill"; // CS8852: Init-only property.


