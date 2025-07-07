using System.Xml.Serialization;

namespace Exercise_SerializingShapes;

[XmlRoot("Circle")]
public class Circle: Shape
{
    [XmlAttribute]
    public double Radius { get; init; }
    public override double Area => Math.PI * Radius * Radius;
}