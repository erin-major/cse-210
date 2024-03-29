using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // string stringTop = _top.ToString();
        // string stringBottom = _bottom.ToString();
        // string stringFull = stringTop + "/" + stringBottom;

        string stringFull = $"{_top}/{_bottom}";

        return stringFull;
    }

    public double GetDecimalValue()
    {
        // double dec = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);

        return (double)_top / (double)_bottom;
    }
}