using Framework.Interface;

namespace Framework.Entidade
{
   public class PedidoFacade
   {
        private readonly IEstoque _Estoque;
        private readonly IFinanceiro _Financeiro;
        private readonly IPosVenda _PosVenda;
        
        public PedidoFacade(IEstoque estoque, IFinanceiro financeiro, IPosVenda posvenda)
        {
            _Estoque = estoque;
            _Financeiro = financeiro;
            _PosVenda = posvenda;
        }

        public void RegistraPedido(IPedido _pedido)
        {
            this._Estoque.EnviaProduto(_pedido.Produto, _pedido.EnderecoEntrega);
            this._Financeiro.Fatura(_pedido.Cliente, _pedido.Produto, _pedido.Fatura);
            this._PosVenda.AgendaContato(_pedido.Cliente, _pedido.Produto);         
        }
   }
}
