public class SwimmingActivity : Activity
{
    private double _numberOfLaps = 0;

    public SwimmingActivity(string date, double lengthInMinutes, double laps) : base(date, lengthInMinutes)
    {
        _numberOfLaps = laps;
    }

    public override double GetDistance()
    {

        double distance = _numberOfLaps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / GetLengthInMinutes() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()}, Swimming ({GetLengthInMinutes()} min): Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km.";
    }
}