using System;
using ExampleOfClasses;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            var nintendo = new Product();

            nintendo.Name = "Switch Lite";
            nintendo.Price = 199.99m;

            Console.WriteLine($"The new {nintendo.Name} is available at the cost of {nintendo.Price}.");
        }
    }
}
