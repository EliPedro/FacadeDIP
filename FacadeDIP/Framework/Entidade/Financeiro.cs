using Framework.Interface;
using System;

namespace Framework.Entidade
{
    public class Financeiro : IFinanceiro
    {
        public void Fatura(string cliente, string produto)
        {
            Console.WriteLine("Fatura: ");
            Console.WriteLine("Cliente: " + cliente);
            Console.WriteLine("Produto: " + produto);
            
        }
    }
}
