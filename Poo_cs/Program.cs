using System;
using System.Globalization;

namespace Poo_cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Produtos prod = new Produtos();

            Console.WriteLine("informe as descrições do produto: ");

            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Qual o preço do produto: ");
            prod.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Quantidade: ");
            prod.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Dados do produto: {prod}");

            Console.WriteLine($"Valor em estoque: {prod.Valor_Total_Estoque()}");

            Console.WriteLine("Adicione produtos: ");
            int quant = int.Parse(Console.ReadLine());

            prod.Adicionar_Produtos(quant);

            Console.Write("Aperte enter para finalizar o programa");
            Console.Read();


        }
    }
}