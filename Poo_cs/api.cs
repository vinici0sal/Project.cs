using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Produtos
{

    public string Nome;
    public double Preco;
    public int Quantidade;

    public double Valor_Total_Estoque()
    {
        return Preco * Quantidade;

    }

    public void Adicionar_Produtos(int quantidade){

        Quantidade += quantidade;

    }

    public override string ToString()
    {
        return Nome 
        + " $"
        + 
        Preco.ToString( CultureInfo.InvariantCulture)
        +
        "  "
        +
        Quantidade
        +
        Valor_Total_Estoque();
        
    }

}