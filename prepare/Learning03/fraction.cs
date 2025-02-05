
using System.Globalization;

public class fraction
{
private int _top = 0; 
private int _bottom = 0;

    public fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

}