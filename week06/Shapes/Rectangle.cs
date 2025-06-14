
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        double _RectangleArea = _length * _width;
        return _RectangleArea;

    }
}