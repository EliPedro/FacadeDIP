using Framework.Interface;
using System;

namespace Framework.Entidade
{
    public class PosVenda : IPosVenda
    {
        public void AgendaContato(string cliente, string produto)
        {
            DateTime date = DateTime.Now;
            date.AddDays(30);

            //string format = String.Format("{0:MM/dd/yyyy", date);

            Console.WriteLine("Entrar em contato com " + cliente + 
                              "sobre o produto " + produto + 
                              " no dia " );

            Console.ReadKey();
        }
    }
}
