namespace Framework.Interface
{
    public interface IPedido
    {
        string Produto { get; set; }
        string Cliente { get; set; }
        string EnderecoEntrega { get; set; }
    }
}
