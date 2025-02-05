
using System.Globalization;

public class Fraction
{
private int _top = 0; 
private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
     public int Top
    {
        get { return _top; }
        set { _top = value; }
    }
    public int Bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }
}