using System.Xml.Serialization;

namespace Exercise_SerializingShapes;

[XmlRoot("Rectangle")]
public class Rectangle: Shape
{
    [XmlAttribute]
    public double Height { get; init; }
    [XmlAttribute]
    public double Width { get; init; }
    public override double Area => Height * Width;
}