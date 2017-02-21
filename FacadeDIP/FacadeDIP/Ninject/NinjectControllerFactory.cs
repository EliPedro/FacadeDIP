using Ninject;
using Framework.Interface;
using Framework.Entidade;
using Ninject.Modules;
using System;

namespace FacadeDIP.Ninject
{
    public class NinjectControllerFactory : NinjectModule
    {
        private IKernel ninjectIkernel;
        
        public override void Load()
        {

            ninjectIkernel.Bind<IEstoque>().To<Estoque>();
            ninjectIkernel.Bind<IFinanceiro>().To<Financeiro>();
            ninjectIkernel.Bind<IPedido>().To<Pedido>();
            ninjectIkernel.Bind<IPosVenda>().To<PosVenda>();

        }
    }
}
