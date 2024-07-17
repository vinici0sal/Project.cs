using System;
using System.Globalization;

namespace Poo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com os dados da conta: ");

            Console.Write("Nome do titular: ");
            string nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Número da conta: ");
            int num_conta = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Vai entrar com o saldo da conta agora? Sim ou Não: ");
            string resp = Console.ReadLine();

            if(resp == "Sim" || resp == "sim")
            {
                Console.Write("Valor do depósito: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Conta_Banco conta = new Conta_Banco(valor, nome, num_conta );
                Console.WriteLine(conta);

                Console.WriteLine();

                Console.Write("Deseja adicionar mais saldo? Sim ou Não?: ");
                string resp2 = Console.ReadLine();

                if(resp2 == "Sim" || resp2 == "sim")
                {
                    Console.Write("Digite o valor do saldo a ser adicionado: ");
                    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();
                    
                    conta.Add_saldo(valor2);
                    Console.WriteLine($"Dados atualizados: {conta.ToString()}");

                    
                }

                Console.WriteLine("Deseja sacar algum valor?: ");
                string resp3 = Console.ReadLine();

                if(resp3 == "Sim" || resp3 == "sim")
                {
                    Console.Write("Digite o valor a ser sacado: ");
                    double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();
                    conta.Saq_Saldo(valor3);
                    Console.WriteLine($"Dados atualizados: {conta.ToString()}");
                } 
            }

            else
            {
                Conta_Banco conta = new Conta_Banco(nome, num_conta);
                Console.WriteLine(conta);
                
            }

        
            
            Console.Read();

        }
    }
}