using System;

public class Fractions
{
    private int _topNumber;
    private int _bottomNumber;

    public Fractions()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fractions(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    public Fractions(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public string GetFractionString()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;

    }

}