using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Product 1", 123, 5);
        Product product2 = new Product("Product 2", 456, 3);
        
        Address address1 = new Address("123 Main St", "City", "State", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        
        Address address2 = new Address("456 Elm St", "City", "State", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        
        Order order1 = new Order(customer1, 5, 35);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        
        Order order2 = new Order(customer2, 5, 35);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.ReturnPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ReturnShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());
        
        Console.WriteLine();
        
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.ReturnPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ReturnShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
    }
}
