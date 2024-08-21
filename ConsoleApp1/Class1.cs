using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSaque
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; set; }

        public virtual void Add()
        {
            Nome = Console.ReadLine();
            CPF = (Console.ReadLine());
            Senha = Console.ReadLine();
            Saldo = int.Parse(Console.ReadLine());
        }

        private void SetSenha(string senha)
        {

            string Senha = Console.ReadLine();
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Senha));
                Senha = Convert.ToBase64String(hashedBytes);
            }

        }


    }



}




