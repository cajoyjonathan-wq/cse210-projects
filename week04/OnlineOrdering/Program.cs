using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("072", "Pagadian City", "Zamobanga Del Sur", "Philippines");
        Customer customer1 = new Customer("David Aguinaldo", address1);

        Product product1 = new Product("Fried Noodles", "ZXC099", 30.01, 3);
        Product product2 = new Product("Eggs", "ZXC455", 10.00, 5);
        Product product3 = new Product("Soy Sauce", "ZXC355", 45.00, 1);

        Address address2 = new Address("1st Avenue", "Chicago City", "Ilinois", "USA");
        Customer customer2 = new Customer("Donald Johnson", address2);

        Product product4 = new Product("Tires", "JKL455", 2000.50, 4);
        Product product5 = new Product("Engine Oil", "JKL500", 120.00, 1);
        Product product6 = new Product("Break Fluid", "JKL365", 245.00, 1);

        Address address3 = new Address("002", "Las Vegas City", "Texas", "USA");
        Customer customer3 = new Customer("Maria Flyer", address3);

        Product product7 = new Product("Milk", "RTY565", 0.61, 4);
        Product product8 = new Product("Bread", "RTY800", 0.10, 3);
        Product product9 = new Product("Sugar", "RTY200", 0.10, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Order order3 = new Order(customer3);
        order3.AddProduct(product7);
        order3.AddProduct(product8);
        order3.AddProduct(product9);

        Console.WriteLine("--------------------------");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("--------------------------");
        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(order1.GetPackLabel());
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("--------------------------");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("--------------------------");
        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(order2.GetPackLabel());
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalCost():F2}\n");

        Console.WriteLine("--------------------------");
        Console.WriteLine("ORDER 3");
        Console.WriteLine("--------------------------");
        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(order3.GetPackLabel());
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order3.GetTotalCost():F2}\n");
    }
}