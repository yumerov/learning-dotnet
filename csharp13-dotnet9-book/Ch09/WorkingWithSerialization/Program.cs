using System.Xml.Serialization;
using WorkingWithSerialization;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using Newtonsoft.Json;
using FastJson = System.Text.Json.JsonSerializer;

List<Person> people =
[
    new(initialSalary: 30_000M)
    {
        FirstName = "Alice",
        LastName = "Smith",
        DateOfBirth = new(year: 1974, month: 3, day: 14)
    },

    new(initialSalary: 40_000M)
    {
        FirstName = "Bob",
        LastName = "Jones",
        DateOfBirth = new(year: 1969, month: 11, day: 23)
    },

    new(initialSalary: 20_000M)
    {
        FirstName = "Charlie",
        LastName = "Cox",
        DateOfBirth = new(year: 1984, month: 5, day: 4),
        Children =
        [
            new(initialSalary: 0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new(year: 2012, month: 7, day: 12)
            }
        ]
    }
];

SectionTitle("Serializing as XML");
XmlSerializer xmlSerializer = new(type: people.GetType());
string path = Combine(CurrentDirectory, "people.xml");
using (FileStream stream = File.Create(path))
{
    xmlSerializer.Serialize(stream, people);
}

OutputFileInfo(path);

SectionTitle("Deserializing XML files");
using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    if (xmlSerializer.Deserialize(xmlLoad) is List<Person> loadedPeople)
    {
        foreach (Person person in loadedPeople)
        {
            WriteLine("{0} has {1} children.", person.LastName, person.Children?.Count ?? 0);
        }
    }
}

SectionTitle("Serializing with JSON");
string jsonPath = Combine(CurrentDirectory, "people.json");
using (StreamWriter jsonStream = File.CreateText(jsonPath))
{
    new JsonSerializer().Serialize(jsonStream, people);
}

OutputFileInfo(jsonPath);

SectionTitle("Deserializing JSON files");
await using (var jsonLoad = File.Open(jsonPath, FileMode.Open))
{
    if (await FastJson.DeserializeAsync(
            utf8Json: jsonLoad,
            returnType: typeof(List<Person>)) is List<Person> loadedPeople)
    {
        foreach (Person person in loadedPeople)
        {
            WriteLine("{0} has {1} children.", person.LastName, person.Children?.Count ?? 0);
        }
    }
}