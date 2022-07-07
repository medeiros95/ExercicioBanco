using System;
using System.Globalization;

namespace ExercicioBanco {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria conta;
            
            Console.WriteLine("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente");
            string titular = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial (S/N) ?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'S' || resp == 's') {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.WriteLine("Entre com o valor do deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            
            Console.WriteLine();

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.WriteLine("Digite o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);



        }
    }
}
