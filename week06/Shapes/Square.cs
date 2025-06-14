public class Square : Shape
{
    private double _side;

    public Square(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double _SquareArea = _side * _side;
        return _SquareArea;
    }
}