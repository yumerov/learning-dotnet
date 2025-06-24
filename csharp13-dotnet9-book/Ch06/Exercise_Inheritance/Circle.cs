namespace Exercise_Inheritance;

public class Circle: Shape
{
    public override double Area => Math.PI * Math.Pow(Height, 2);

    public Circle(double radius) : base(height: radius, width: radius)
    {
        Height = radius;
        Width = radius;
    }
}