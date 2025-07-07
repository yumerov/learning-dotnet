using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WorkingWithSerialization;

public class Person
{
    public Person() { }
    
    public Person(decimal initialSalary)
    {
        Salary = initialSalary;
    }

    [XmlAttribute("fname")]
    [JsonProperty("fname")]
    public string? FirstName { get; set; }
    [XmlAttribute("lname")]
    [JsonProperty("lname")]
    public string? LastName { get; set; }
    [XmlAttribute("dob")]
    [JsonProperty("dob")]
    public DateTime DateOfBirth { get; set; }
    public HashSet<Person>? Children { get; set; }
    protected decimal Salary { get; set; }
}