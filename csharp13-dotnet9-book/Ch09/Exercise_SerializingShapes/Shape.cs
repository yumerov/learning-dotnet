using System.Xml.Serialization;

namespace Exercise_SerializingShapes;

[XmlInclude(typeof(Circle))]
[XmlInclude(typeof(Rectangle))]
public abstract class Shape
{
    [XmlAttribute]
    public required string Colour { get; set; }
    [XmlAttribute]
    public abstract double Area { get; }
}