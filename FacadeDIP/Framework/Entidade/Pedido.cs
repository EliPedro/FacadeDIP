using Framework.Interface;

namespace Framework.Entidade
{
    public class Pedido : IPedido
    {
        public string Produto { get; set; }
        public string Cliente { get; set; }
        public string EnderecoEntrega { get; set; }
        public string Fatura { get; set; }

        public Pedido(string produto, string cliente, string enderecoEntrega, string fatura)
        {
            this.Produto = produto;
            this.Cliente = cliente;
            this.EnderecoEntrega = enderecoEntrega;
            this.Fatura = fatura;
        }
    }
}
