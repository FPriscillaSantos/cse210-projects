class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address) 
    {
        _name = name;
        _address = address;
    }

    public bool International() 
    {
        return !_address.InUSA();
    }

    public Address Address 
    {
        get { return _address; }
    }
}