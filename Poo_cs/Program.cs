using System;
using System.Globalization;

namespace Poo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos prod = new Produtos();

            Console.WriteLine($"Dados do produto: {prod}");

            Console.WriteLine($"Valor em estoque: {prod.Valor_Total_Estoque()}");

            Console.WriteLine("Adicione produtos: ");
            int quant = int.Parse(Console.ReadLine());

            prod.Adicionar_Produtos(quant);

            Console.WriteLine($"Dados autualizados:{prod}");

            Console.WriteLine("Remova produtos: ");
            int quant2 = int.Parse(Console.ReadLine());
            prod.Remover_Produtos(quant2);

            Console.WriteLine($"Dados atualizados: {prod}");

            Console.Write("Aperte enter para finalizar o programa");
            Console.Read(); 


        }
    }
}