public class CyclingActivity : Activity
{
    private double _speed = 0;
    public CyclingActivity(string date, double lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = 0;
        distance = GetSpeed() * GetLengthInMinutes() / 60; 
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 0;
        pace = 60 / GetSpeed();
        return pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()}, Cycling ({GetLengthInMinutes()} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km.";
    }
}