using System;
using System.Globalization;

namespace Poo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da conta: ");
            Console.Write("Titular: "); 
            string nome = Console.ReadLine();
            Console.Write("Saldo: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int conta = int.Parse(Console.ReadLine());

            Conta_Banco cont = new Conta_Banco(nome, valor, conta);
            Console.Read();
           
            
        }
    }
}