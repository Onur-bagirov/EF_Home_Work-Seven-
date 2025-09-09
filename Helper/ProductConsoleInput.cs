using StoreAppProject.Exceptions;
using StoreAppProject.Models;

namespace StoreAppProject.Helper;

static class ProductConsoleInput
{
    public static Product ConsoleInput()
    {
        Console.WriteLine("Enter Product Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Product Description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Product Price:");
        double price = double.Parse(Console.ReadLine());
        if (price < 0)
        {
            throw new InvalidPriceException();
        }
        Product product = new Product
        {
            Name = name,
            Description = description,
            Price = price
        };
        return product;
    }
}