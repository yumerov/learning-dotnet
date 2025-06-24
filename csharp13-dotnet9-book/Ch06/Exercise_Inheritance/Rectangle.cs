namespace Exercise_Inheritance;

public class Rectangle(double height, double width) : Shape(height, width)
{
    public override string ToString() => $"Rectangle {base.ToString()}";
}