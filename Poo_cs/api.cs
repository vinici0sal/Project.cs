using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Produtos
{

    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produtos(){

        Console.WriteLine("Informe os dados do Produto: ");
        Console.WriteLine();

        Console.WriteLine("Quantidade");
        Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Preço: ");
        Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Produto: ");
        
        Nome = Console.ReadLine();
    }

    public double Valor_Total_Estoque()
    {
        return Preco * Quantidade;

    }

    public void Adicionar_Produtos(int quantidade)
    {

        Quantidade += quantidade;

    }

    public void Remover_Produtos(int quantidade)
    {

        Quantidade -= quantidade;

    }

    public override string ToString()
    {
        return Nome
        + ", $"
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + Valor_Total_Estoque().ToString("F2", CultureInfo.InvariantCulture);


    }

    

}