using System.Xml.Serialization;
using Exercise_SerializingShapes;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

List<Shape> shapes = [
    new Circle { Colour = "Red", Radius = 2.5 },
    new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
    new Circle { Colour = "Green", Radius = 8.0 },
    new Circle { Colour = "Purple", Radius = 12.3 },
    new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
];
const string file = "shapes.xml";

XmlSerializer xmlSerializer = new(type: shapes.GetType());
var path = Combine(CurrentDirectory, file);
await using (var stream = File.Create(path))
{
    xmlSerializer.Serialize(stream, shapes);
}

await using (var xmlLoad = File.Open(path, FileMode.Open))
{
    if (xmlSerializer.Deserialize(xmlLoad) is List<Shape> loadedShapes)
    {
        WriteLine("Loading shapes from XML:");
        foreach (var shape in loadedShapes)
        {
            WriteLine("{0} is {1} and has an area of {2:F2}", shape.GetType().Name, shape.Colour, shape.Area);
        }
    }
}