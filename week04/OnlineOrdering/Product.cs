public class Product
{
    private string _name = "";
    private string _productId = "";
    private double _price = 0;
    private int _productQuantity = 0;

    public Product(string name, string productId, double price, int productquantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _productQuantity = productquantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
    
    public double GetTotalCost()
    {
        return _price * _productQuantity;
    }
}