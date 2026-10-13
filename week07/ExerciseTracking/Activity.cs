using System.Dynamic;

public abstract class Activity
{
    private string _date = "";
    private double _lengthInMinutes = 0;

    public Activity(string date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetSummary();

}