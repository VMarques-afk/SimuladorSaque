using System;

namespace SimuladorSaque
{
    public class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000.0;
            double taxaSaque = 5.0;

            bool retorno = true;

            while (retorno)
            {
                Console.Write("Digite o valor que deseja sacar: R$ ");
                if (double.TryParse(Console.ReadLine(), out double valorSaque))
                {
                    double valorTotal = valorSaque + taxaSaque;
                    //maior ou igual, 
                    if (saldo >= valorTotal)
                    {
                        saldo -= valorTotal;
                        Console.WriteLine($"Saque realizado com sucesso! Seu novo saldo é: R$ {saldo:F2}");// :F2 ferramenta para formatar valores numéricos
                    }

                    else
                    {    //retorna se tiver erro no valor =< lembrando que o retorno tem a taxa então não pode retonar o valor exato "Saldoconta"
                        Console.WriteLine("Valor inválido. Saldo insuficiente.");
                    }
                    //retorno
                    Console.Write("Deseja fazer uma nova operação? (S/N): ");
                    string resposta = Console.ReadLine().ToUpper();

                    retorno = resposta == "S";
                }
                else
                {
                    //aqui encerra caso "N"
                    Console.WriteLine("Valor inválido. Por favor, digite um número válido.");
                }
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            
        }
    }
}