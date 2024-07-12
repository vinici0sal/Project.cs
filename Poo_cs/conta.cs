using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Conta_Banco
{
    private string Titular;
    private double Saldo;
    private int Conta;

    public Conta_Banco(string titular, double saldo, int conta)
    {
        Titular = titular;
        Saldo = saldo;
        Conta = conta;

        Console.WriteLine($"Dados da conta \n\nTitular: {Titular}, Conta: {Conta}, Saldo: {Saldo}");
        Console.Read();
    }

    public double Add_Saldo(int ndepo)
    {
        Saldo = Saldo + ndepo;
        return Saldo;
    }

    public double Remover_Saldo(int ndepo2)
    {
        Saldo = Saldo - ndepo2;
        return Saldo;
    }

    public int GetConta()
    {
        return Conta;
    }



}
