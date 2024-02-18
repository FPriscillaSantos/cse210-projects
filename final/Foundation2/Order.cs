class Order {
    private List<Product> _products;
    private Customer _customer;
    private float _domesticShippingCost;
    private float _internationalShippingCost;

    public Order(Customer customer, float domesticShippingCost, float internationalShippingCost) 
    {
        _products = new List<Product>();
        _customer = customer;
        _domesticShippingCost = domesticShippingCost;
        _internationalShippingCost = internationalShippingCost;
    }

    public void AddProduct(Product product) 
    {
        _products.Add(product);
    }

    public string ReturnShippingLabel() 
    {
    return $"Customer: {_customer.Address.DisplayAddress()}";
    }

    public string ReturnPackingLabel() 
    {
        string packingLabel = "";
        foreach (var product in _products) {
            packingLabel += $"Product: {product.TotalCost(10)}, {_customer.Address.DisplayAddress()}\n";
        }
        return packingLabel;
    }
    public float CalculateTotalPrice() 
    {
        float totalPrice = 0;
        foreach (var product in _products) 
        {
            totalPrice += product.TotalCost(10);
        }

        if (_customer.International()) 
        {
            return totalPrice + _internationalShippingCost;
        } 
        
        else 
        {
            return totalPrice + _domesticShippingCost;
        }
    }
}