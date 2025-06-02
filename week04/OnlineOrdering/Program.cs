using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Ohawa St", "Detroit", "Michigan", "USA");
        Customer customer1 = new Customer("Bartolomeo Perez", address1);
        Product product1 = new Product("Computer", "T532", 599.99, 2);
        Product product2 = new Product("Keyboard", "S555", 15.50, 2);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");


        // Not USA
        Address address2 = new Address("859 St John", "Edmonton", "Alberta", "Canada");
        Customer customer2 = new Customer("Renato Gonzales", address2);
        Product product3 = new Product("Laptop", "S858", 600.00, 1);
        Product product4 = new Product("Wireless Headphones", "T454", 50.56, 1);
        Product product5 = new Product("Wireless mouse", "W555", 30.99, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}