// See https://aka.ms/new-console-template for more information

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


