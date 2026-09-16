public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}


public class Receipt
{
    public string _date;
    public string _products;
    public int _price;
    public void Display()
    {
        Console.WriteLine($"{_date} {_products} {_price}");
    }
}