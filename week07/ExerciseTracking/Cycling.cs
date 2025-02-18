public class Cycling(DateTime date, int minutes, double speed) : Activity(minutes, date)
{
    private double _speed = speed;

    public override double GetDistance() => _speed * GetMinutes() / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / _speed;
}