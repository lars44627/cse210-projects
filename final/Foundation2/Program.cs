using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "KB123", 29.99, 2));
        order1.AddProduct(new Product("Mouse", "MS456", 19.99, 1));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Order 1 Total Price: ${order1.GetTotalCost():F2}\n");

        Address address2 = new Address("45 Elm Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emily Wong", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("USB Cable", "USB789", 5.99, 3));
        order2.AddProduct(new Product("Laptop Stand", "LS321", 45.50, 1));

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Order 2 Total Price: ${order2.GetTotalCost():F2}");
    }
}