namespace Exercise_Inheritance;

public class Square : Shape
{
    public Square(double side) : base(height: side, width: side)
    {
        Height = side;
        Width = side;
    }
}