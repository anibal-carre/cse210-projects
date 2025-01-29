using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new("456 Elm St", "Toronto", "ON", "Canada");


        Customer customer1 = new("John Doe", address1);
        Customer customer2 = new("Jane Smith", address2);


        Product product1 = new("Laptop", "A123", 1000.00m, 1);
        Product product2 = new("Mouse", "B456", 25.00m, 2);
        Product product3 = new("Monitor", "C789", 200.00m, 1);
        Product product4 = new("Keyboard", "D012", 50.00m, 1);


        Order order1 = new(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);


        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine();


        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
    }
}