using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Conta_Banco
{
    public string Titular { get; set; }
    public double Saldo { get; private set; }
    public int Conta{ get; private set; }

    public Conta_Banco(string titular, int conta)
    {
        Titular = titular;
        Conta = conta;       
    }

    public Conta_Banco(double saldo, string titular, int conta) :  this( titular, conta)
    {
        Saldo = saldo;        

    }

    public double Add_saldo(double saldo1)
    {
        
        Saldo += saldo1;
        return Saldo;

    }

    public double Saq_Saldo(double valor)
    {
        Saldo -= valor + 5;
        return Saldo;
    }

    public override string ToString()
    {
        return "Conta: "
        +
        Conta
        +
        " Saldo: "
        +
        Saldo.ToString("F2", CultureInfo.InvariantCulture)
        +
        " "
        +
        "Titular: "
        +
        Titular;        
    }
}
