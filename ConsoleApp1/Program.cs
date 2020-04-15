using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Hávera depósito Inicial (s/n)?");
            char teste = char.Parse(Console.ReadLine());
            if (teste == 's' || teste == 'S')
            {
                Console.Write("Qual o valor do Depósito Inicial ?");
                double inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(numero, titular, inicial);
            }
            else
            {
                c1 = new Conta(numero, titular);
            }
              
            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c1);

            Console.WriteLine();

            Console.Write("Entre um valor para Depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(valor);
            Console.WriteLine("Dados da Conta Atualizados:");
            Console.WriteLine(c1);

            Console.Write("Entre um valor para saque");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(valor);
            Console.WriteLine("Dados da Conta Atualizados:");
            Console.WriteLine(c1);


        }
    }
}
