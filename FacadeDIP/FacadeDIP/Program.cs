using Framework.Entidade;
using Framework.Interface;
using Ninject;
using System;

namespace FacadeDIP
{
    /*
      Objetivo: Prover uma interface simplificada para 
      a utilização de várias interfaces de um subsistema.
    */

    class Program
    {
        public static IKernel ninjectIkernel = new StandardKernel();

        static void Main(string[] args)
        {

            AddBiding();

            var estoque = ninjectIkernel.Get<IEstoque>();
            var financeiro = ninjectIkernel.Get<IFinanceiro>();
            var posVenda = ninjectIkernel.Get<IPosVenda>();

            PedidoFacade facade = new PedidoFacade(estoque, financeiro, posVenda);

            IPedido pedido = new Pedido("Notebook", "Rafael Cosentino",
                                       "Av Brigadeiro Faria Lima , 1571," +
                                       "São Paulo , SP");
           facade.RegistraPedido(pedido);
            
           Console.ReadKey();
            
        }

        private static void AddBiding()
        {            
            ninjectIkernel.Bind<IEstoque>().To<Estoque>();
            ninjectIkernel.Bind<IFinanceiro>().To<Financeiro>();
            ninjectIkernel.Bind<IPosVenda>().To<PosVenda>();
        }       
    }
}
