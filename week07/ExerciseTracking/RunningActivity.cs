public class RunningActivity : Activity
{
    private double _distance = 0;

    public RunningActivity(string date, double lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = 0;
        speed = _distance / GetLengthInMinutes() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = 0;
        pace = GetLengthInMinutes() / _distance;
        return pace;
    }
    
    
    public override string GetSummary()
    {
        return $"{GetDate()}, Running ({GetLengthInMinutes()} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km.";
    }
}