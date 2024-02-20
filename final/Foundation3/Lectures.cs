class Lectures : Event
{
    private string _speakerName;
    private string _capacity;
    
    public Lectures(string title, string description, DateTime date, DateTime time, Address address) 
        : base(title, description, date, time, address)
    {
        
    }

    public override void DisplayFullDetails() 
    {
        Console.WriteLine ($"{_title}: {_description} \r\n{_speakerName} \r\n{_date}, {_time} \r\n {_address} Capacity: {_capacity}");
    }
}