class Product {
    private string _productName;
    private float _productID;
    private int _quantity;

    public Product(string productName, float productID, int quantity) 
    {
        _productName = productName;
        _productID = productID;
        _quantity = quantity;
    }

    public float TotalCost(int total) 
    {
        return total * _quantity;
    }
}