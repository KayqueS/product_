using System;

namespace product_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product_data x = new Product_data();

            Console.WriteLine("Enter product data:");

            Console.Write("Name: ");
            x.Product = Console.ReadLine();
            Console.Write("Value: ");
            x.Value = double.Parse(Console.ReadLine());
            Console.Write("Quantity in stock: ");
            x.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Product data: {x}");
            Console.WriteLine();

            Console.Write("Enter the number of products to be added to the stock: ");
            int add = int.Parse(Console.ReadLine());
            x.AddProduct(add);


            Console.WriteLine();
            Console.WriteLine($"Updated data: {x}");
            Console.WriteLine();

            Console.Write("Enter the number of products to be removed from stock: ");
            int remove = int.Parse(Console.ReadLine());
            x.RemoveProduct(remove);

            Console.WriteLine();
            Console.WriteLine($"Updated data: {x}");
            Console.WriteLine();
        }
    }
}
