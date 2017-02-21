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
          
                Console.WriteLine("---- " + produto + " ----\n");

                Console.WriteLine("O produto " + produto +
                                  "será entregue no endereço " + enderecoEntrega
                                  + " até as 18h do dia " + DateTime.Now.AddDays(2).ToShortDateString() + "\n");
                
              
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }
    }
}
