using System;

namespace SimuladorSaque
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double saldo = 1000.0; 
            double taxaSaque = 5.0; 

           
            Console.Write("Digite o valor que deseja sacar: R$ ");
            if (double.TryParse(Console.ReadLine(), out double valorSaque))
            {
                
                double valorTotal = valorSaque + taxaSaque;

               
                if (saldo >= valorTotal)
                {
                    saldo -= valorTotal;
                    Console.WriteLine($"Saque realizado com sucesso! Seu novo saldo é: R$ {saldo:F2}");
                    Console.WriteLine(saldo);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar o saque.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número válido.");
               

            }
        }
    }
}
