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

        public void RegistraPedido(Pedido pedido)
        {
            this._Estoque.EnviaProduto(pedido.Produto, pedido.EnderecoEntrega);
            this._Financeiro.Fatura(pedido.Cliente, pedido.Produto);
            this._PosVenda.AgendaContato(pedido.Cliente, pedido.Produto);         
        }
   }
}
