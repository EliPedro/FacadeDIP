using Framework.Interface;
using System;
using System.Linq;

namespace Framework.Entidade
{
    public class Financeiro : IFinanceiro
    {
        public void Fatura(string cliente, string produto)
        {

            Console.WriteLine("---- " + cliente + " ----\n");
           
            Console.WriteLine("Fatura: " + AlfanumericoAleatorio());
            Console.WriteLine("Cliente: " + cliente);
            Console.WriteLine("Produto: " + produto);

        }

        private string AlfanumericoAleatorio()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 10)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
