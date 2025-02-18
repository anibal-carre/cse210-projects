public abstract class Activity(int minutes, DateTime date)
{
    private int _minutes = minutes;
    private DateTime _date = date;

    public int GetMinutes()
    {
        return _minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {

        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance(): 0.0} km, Speed: {GetSpeed(): 0.0} kph, Pace: {GetPace(): 0.0} min per km";
    }
}