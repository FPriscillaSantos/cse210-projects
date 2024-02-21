class Receptions : Event
{
    protected string _email;

    public Receptions(string title, string description, DateTime date, DateTime time, string address) 
        : base(title, description, date, time, address)
    {
        type = "Receptions";
    }
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public override void DisplayFullDetails() 
    {
        Console.WriteLine ($"{_title}: {_description}  \r\n{_date.ToShortDateString()}, {_time.ToShortTimeString()} \r\n{_address} \r\nEmail: {_email}");
    }
}