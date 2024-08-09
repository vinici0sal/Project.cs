using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualBasic;
using RestSharp;


namespace Poo_cs
{
    class Program
    {

     static void Main(string []args)
     {
        static void Departamentos()
        {
            var requests = new RestRequest(" ", Method.Get);
            var cliente = new RestClient("https://api.tomticket.com/departamentos/ce3197981dba2d2ed25bfa360b699725837154e665acdbc79258d0900768871e" );
            var response = cliente.Execute(requests);
            Console.WriteLine(response.Content);
        }
        
        static void Criar_Chamado()
        {
            /* Invocar método post */
            var requests = new RestRequest(" ", Method.Post);

            /* Adicionar os parâmetros */
            requests.AddParameter("titulo", "Chamado via c#");
            requests.AddParameter("id_departamento", "b77664898f3b1d7d01f6d2e01fe92db8");
            requests.AddParameter("mensagem", "Chamado criado com a linguagem c#");
            requests.AddParameter("id_tipoassunto", "561d231267df833248b0e2c0109d4d9a");

            /*Utilizando a api pra envio das informações  */
            var cliente = new RestClient("https://api.tomticket.com/criar_chamado/ce3197981dba2d2ed25bfa360b699725837154e665acdbc79258d0900768871e/013329");

            /* Recebendo as informações para  */
            var response = cliente.Execute(requests);
            Console.WriteLine(response.Content);
        }

        Criar_Chamado();

        Console.ReadKey();
     }

    }
}