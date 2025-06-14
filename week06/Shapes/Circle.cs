public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double _CircleArea = Math.PI * _radius * _radius;
        return _CircleArea;
    }
}