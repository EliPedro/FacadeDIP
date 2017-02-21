using Framework.Interface;
using System;

namespace Framework.Entidade
{
    public class Financeiro : IFinanceiro
    {
        public void Fatura(string cliente, string produto, string fatura)
        {

            Console.WriteLine("---- " + cliente + " ----\n");
           
            Console.WriteLine("Fatura: " + fatura);
            Console.WriteLine("Cliente: " + cliente);
            Console.WriteLine("Produto: " + produto);

        }
    }
}
