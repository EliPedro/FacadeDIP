using Framework.Interface;
using System;

namespace Framework.Entidade
{
    public class PosVenda : IPosVenda
    {
        public void AgendaContato(string cliente, string produto)
        {
            try
            {
                Console.WriteLine("\n---- " + cliente + "----\n");

                Console.WriteLine("Entrar em contato com " + cliente +
                                  " sobre o produto " + produto +
                                  " no dia " + DateTime.Now.AddDays(30).ToShortDateString());

                Console.WriteLine("---- ---- ---- ----");

            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
