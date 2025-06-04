using System;
public class Fractions
{

    private int _top;
    private int _bottom;
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionstring = $"{_top}/{_bottom}";
        return fractionstring;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / _bottom;
        return decimalValue;
    }
}