using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _product;

    public Order(Customer customer)
    {
        _customer = customer;
        _product = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _product)
        {
            total += product.GetTotalCost();
        }

        if (_customer.IsInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackLabel()
    {
        string label = "";

        foreach (Product product in _product)
        {
            label += $"{product.GetProductName()} - {product.GetProductId()}\n";
        }
        return label;
    }
    
    public string GetShippingLabel()
    {
        string label = $"{_customer.GetName()}\n{_customer.GetAddress()}";
        return label;
    }
}