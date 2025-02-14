public abstract class Goal(string shortName, string description, string points)
{
    protected string _shortName = shortName;
    protected string _description = description;
    protected string _points = points;

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public string GetPoints()
    {
        return _points;
    }


    public abstract string GetStringRepresentation();
}