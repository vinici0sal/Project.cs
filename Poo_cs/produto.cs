using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Produtos
{

    private string _nome;
    private double _preco;
    private int _quantidade;

    public Produtos(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string Nome
    {
        get { return _nome; }
        
    }

         public override string ToString()
    {
        return _nome
        + ", $"
        + _preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + _quantidade;


    } 


}

     