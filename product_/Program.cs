using System;

namespace product_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product_data x = new Product_data();

            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            x.Product = Console.ReadLine();
            Console.Write("Preço: ");
            x.Value = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            x.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {x}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            x.AddProduct(add);


            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {x}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int remove = int.Parse(Console.ReadLine());
            x.RemoveProduct(remove);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {x}");
            Console.WriteLine();
        }
    }
}
