public class Swimming(DateTime date, int minutes, int laps) : Activity(minutes, date)
{
    private int _laps = laps;

    public override double GetDistance()
    {
        double distanceInMeters = _laps * 50;
        return distanceInMeters / 1000;
    }

    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / GetDistance();
}