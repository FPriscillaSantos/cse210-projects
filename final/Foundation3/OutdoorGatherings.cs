class OutdoorGatherings : Event
{
    protected string _weather;

        public OutdoorGatherings(string title, string description, DateTime date, DateTime time, Address address) 
        : base(title, description, date, time, address)
    {
        type = "Outdoor Gatherings";
    }

    public override void DisplayFullDetails() 
    {
        Console.WriteLine ($"{_title}: {_description}  \r\n{_date}, {_time} \r\n {_address} \r\nWeather: {_weather}");
    }
}