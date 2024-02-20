class Receptions : Event
{
    protected string _email;

    public Receptions(string title, string description, DateTime date, DateTime time, Address address) 
        : base(title, description, date, time, address)
    {
        
    }

    public override void DisplayFullDetails() 
    {
        Console.WriteLine ($"{_title}: {_description}  \r\n{_date}, {_time} \r\n {_address} \r\nEmail: {_email}");
    }
}