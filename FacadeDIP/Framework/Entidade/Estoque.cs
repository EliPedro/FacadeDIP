using Framework.Interface;
using System;

namespace Framework.Entidade
{
    public class Estoque : IEstoque
    {
        public void EnviaProduto(string produto, string enderecoEntrega)
        {
            try
            {
                DateTime date = DateTime.Now;
                date.AddDays(2);

                string format = String.Format("{0:MM/dd/yyyy", date);

                Console.WriteLine("O produto " + produto +
                                  "será entregue no endereço " + enderecoEntrega
                                  + " até as 18h do dia ");
            }catch(Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }
    }
}
