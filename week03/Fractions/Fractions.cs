using System.Dynamic;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fractions(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string fractionText = $"{_top}/{_bottom}";
        return fractionText;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double) _bottom;
    }
}