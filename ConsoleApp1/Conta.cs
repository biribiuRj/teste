using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Conta
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Titular = titular;
            Numero = numero;
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
