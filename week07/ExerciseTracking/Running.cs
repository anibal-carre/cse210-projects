public class Running(DateTime date, int minutes, double distance) : Activity(minutes, date)
{
    private double _distance = distance;

    public override double GetDistance() => _distance;
    public override double GetSpeed() => _distance / GetMinutes() * 60;
    public override double GetPace() => GetMinutes() / _distance;
}