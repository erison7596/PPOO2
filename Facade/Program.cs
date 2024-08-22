using Facade.Facade;
using Facade.Models;
using Facade.Services;

public class Program
{
    public static void Main(string[] args)
    {
        
        Produto produto = new Produto(1, "Celular");

        PedidoFacade pedido = new PedidoFacade(new ServicoEstoque(), new ServicoPagamento(), new ServicoRemessa());
        
        Produto produto1 = new Produto(2, "Tablet");
        PedidoFacade pedido1 = new PedidoFacade(new ServicoEstoque(), new ServicoPagamento(), new ServicoRemessa());

        pedido.ProcessOrder(produto);

        pedido1.ProcessOrder(produto1);
    }
}
