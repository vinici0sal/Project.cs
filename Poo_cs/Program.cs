using System;
using System.Globalization;


namespace Poo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos prod = new Produtos("Tv", 200.00, 50);

  
            
            Console.WriteLine(prod.Nome);
            Console.ReadLine();

       }


    }
}
