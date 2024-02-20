using System.Net.Sockets;

class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _time;
    protected DateTime _date;
    protected Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string DisplayStandardDetails()
    {
    
        return $"{_title}, {_description} {_date} {_time}  {_address}";

    }

    public virtual void DisplayFullDetails()
    {}

    public string DisplayShortDescription()
    {
        return $"{_title}, {_date}";
    }
}