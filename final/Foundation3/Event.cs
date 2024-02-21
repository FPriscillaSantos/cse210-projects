using System.Net.Sockets;

class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _time;
    protected DateTime _date;
    protected string _address;
    protected string type;

    public Event(string title, string description, DateTime date, DateTime time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string DisplayStandardDetails()
    {
    
        return $"{_title}, \r\nDescription: {_description} \r\n{_date.ToShortDateString()} {_time.ToShortTimeString()}  \r\n{_address}";

    }

    public virtual void DisplayFullDetails()
    {}

    public string DisplayShortDescription()
    {
        return $"{_title} \r\n{_date} \r\n{type}";
    }
}