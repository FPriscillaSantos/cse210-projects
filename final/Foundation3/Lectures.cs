class Lectures : Event
{
    private string _speakerName;
    private string _capacity;
    
    public Lectures(string title, string description, DateTime date, DateTime time, string address) 
        : base(title, description, date, time, address)
    {
        type = "Lectures";
    }

    public string SpeakerName
    {
        get { return _speakerName; }
        set { _speakerName = value; }
    }

    public string Capacity
    {
        get { return _capacity; }
        set { _capacity = value; }
    }

    public override void DisplayFullDetails() 
    {
        Console.WriteLine ($"{_title}: {_description} \r\n{_speakerName} \r\n{_date}, {_time} \r\n {_address} Capacity: {_capacity}");
    }
}