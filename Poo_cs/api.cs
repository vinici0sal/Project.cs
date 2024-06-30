using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Course
{
    class Tst{
        static void Main(string[] args){

            object api = ("https://api.tomticket.com/criar_chamado/817c0c01d03ba0382b8f940de94c5f8d56c5fda05b1c55fb730f694ffd6f51f0/3221");
            bool erro = false;


            Dictionary<string, string> info = new Dictionary<string, string>();{
            info["id_departamento"] = "b06d8cd6a84ad662633553e92b0b608a";
            info["titulo"] = "Chamado Teste";
            info["mensagem"] = "Chamado teste utilizando a linguagem c#";
            info["tipo_assunto"] = "aa8674a3c66018b05325caa19c7f7dfd";

            }

        

        }
    }
}