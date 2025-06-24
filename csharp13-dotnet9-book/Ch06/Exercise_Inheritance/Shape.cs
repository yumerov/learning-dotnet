namespace Exercise_Inheritance;

public abstract class Shape(double height, double width)
{
    protected double Height { get; init; } = height;
    protected double Width { get; init; } = width;
    protected virtual double Area => Width * Height;

    public override string ToString() => $"H: {Height}, W: {Width}, Area: {Area}";
}