class OutdoorGatherings : Event
{
    protected string _weather;

        public OutdoorGatherings(string title, string description, DateTime date, DateTime time, string address) 
        : base(title, description, date, time, address)
    {
        type = "Outdoor Gatherings";
    }

    public string Weather
    {
        get { return _weather; }
        set { _weather = value; }
    }

    public override void DisplayFullDetails() 
    {
        Console.WriteLine ($"{_title}: {_description}  \r\n{_date.ToShortDateString()}, {_time.ToShortTimeString()} \r\n{_address} \r\nWeather: {_weather}");
    }
}