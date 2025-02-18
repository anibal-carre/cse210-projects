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

        return $"{_date.ToString("dd MM yyyy")}";
    }
}