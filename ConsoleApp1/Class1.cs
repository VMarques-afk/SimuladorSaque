using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace SimuladorSaque
{
    public class Cliente
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public string Nome { get; set; }
        public string CPF { get; set; }
        internal string Senha { get; set; }
        public double Saldo { get; set; }

        public virtual void Add()
        {
            Nome = Console.ReadLine();
            CPF = (Console.ReadLine());
            Senha = Console.ReadLine();
            Saldo = double.Parse(Console.ReadLine());
        }

        void CadastraCliente(string cliente)
        {

            List<Cliente> clientes = new List<Cliente>();
            {
                Console.WriteLine("Digite o seu nome:");
                Nome = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");
                Senha = Console.ReadLine();
                Senha = HashSenha(Senha);

                clientes.Add(this);
            }
        }
        private static string HashSenha(string Senha)
        {

            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Senha));
                return Convert.ToBase64String(hashedBytes);
            }
        }

    }

}