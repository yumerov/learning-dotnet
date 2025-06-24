namespace Exercise_Inheritance;

public abstract class Shape(double height, double width)
{
    public double Height { get; set; } = height;
    public double Width { get; set; } = width;
    public virtual double Area => Width * Height;

    public override string ToString() => $"H: {Height}, W: {Width}, Area: {Area}";
}