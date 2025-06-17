namespace Packt.Shared;

public class PersonComparer : IComparer<Person?>
{
    public int Compare(Person? x, Person? y)
    {
        if (x is null) return -1;
        if (y is null) return 1;
        if (x.Name is not null && y.Name is not null) return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        if (x.Name is not null && y.Name is null) return -1;
        if (x.Name is null && y.Name is not null) return 1;

        return 0;
    }
}