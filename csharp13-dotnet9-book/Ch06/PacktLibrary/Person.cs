namespace Packt.Shared;

public class Person: IComparable<Person>
{
    # region Properties
    public string? Name { get; set; }
    public DateTimeOffset Born { get; set; }
    public List<Person> Children { get; set; } = [];
    // Allow multiple spouses to be stored for a person.
    public List<Person> Spouses { get; set; } = [];
    // A read-only property to show if a person is married to anyone.
    public bool Married => Spouses.Count > 0;

    # endregion
    
    # region Methods
    # region Instance
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }
    
    public void WriteChildrenToConsole()
    {
        var term = Children.Count == 1 ? "child" : "children";
        WriteLine($"{Name} has {Children.Count} {term}.");
    }
    
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }
    
    public void Marry(Person partner)
    {
        Marry(this, partner); 
    }
    
    public void OutputSpouses()
    {
        if (Married)
        {
            string term = Spouses.Count == 1 ? "person" : "people";
            WriteLine($"{Name} is married to {Spouses.Count} {term}:");
            foreach (Person spouse in Spouses)
            {
                WriteLine($"  {spouse.Name}");
            }
        }
        else
        {
            WriteLine($"{Name} is a singleton.");
        }
    }
    
    public virtual void Sing()
    {
        WriteLine("Singing...");
    }
    
    public void TimeTravel(DateTime when)
    {
        if (when <= Born)
        {
            throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
        }

        WriteLine($"Welcome to {when:yyyy}!");
    }
    # endregion
    
    # region Static
    public static void Marry(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);
        if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(
                string.Format("{0} is already married to {1}.",
                    arg0: p1.Name, arg1: p2.Name));
        }
        p1.Spouses.Add(p2);
        p2.Spouses.Add(p1);
    }

    /// <summary>
    /// Static method to "multiply" aka procreate and have a child together.
    /// </summary>
    /// <param name="p1">Parent 1</param>
    /// <param name="p2">Parent 2</param>
    /// <returns>A Person object that is the child of Parent 1 and Parent 2.</returns>
    /// <exception cref="ArgumentNullException">If p1 or p2 are null.</exception>
    /// <exception cref="ArgumentException">If p1 and p2 are not married.</exception>
    public static Person Procreate(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);
        if (!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(string.Format(
                "{0} must be married to {1} to procreate with them.",
                arg0: p1.Name, arg1: p2.Name));
        }

        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            Born = DateTimeOffset.Now
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }
    # endregion
    # endregion
    
    #region Operators
    /// <summary>
    /// Marry
    /// </summary>
    /// <see cref="Marry(Packt.Shared.Person)"/>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <returns></returns>
    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);

        return p1.Married && p2.Married;
    }
    
    /// <summary>
    /// Procreate
    /// </summary>
    /// <see cref="Procreate"/>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <returns></returns>
    public static Person operator *(Person p1, Person p2) => Procreate(p1, p2);
    #endregion

    public int CompareTo(Person? other)
    {
        if (other is null) return -1;
        if (Name is not null && other.Name is not null) return string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (Name is not null && other.Name is null) return -1;
        if (Name is null && other.Name is not null) return 1;

        return 0;
    }
}