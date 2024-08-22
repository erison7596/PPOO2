using Facade.Models;
using Facade.Services;

namespace Facade.Facade
{
    public class PedidoFacade
    {
        private readonly ServicoEstoque _estoque;
        private readonly ServicoPagamento _pagamento;
        private readonly ServicoRemessa _remessa;

        public PedidoFacade(ServicoEstoque estoque, ServicoPagamento pagamento, ServicoRemessa remessa)
        {
            _estoque = estoque;
            _pagamento = pagamento;
            _remessa = remessa;
        }

        public bool ProcessOrder(Produto produto)
        {
            if (!ServicoEstoque.IsAvailable(produto))  // Corrigido para acessar método estático
            {
                System.Console.WriteLine("Produto não disponível no estoque.");
                return false;
            }

            if (!ServicoPagamento.MakePayment())  // Corrigido para acessar método estático
            {
                System.Console.WriteLine("Falha no pagamento.");
                return false;
            }

            ServicoEstoque.AtualizarEstoque(produto);  // Corrigido para acessar método estático
            ServicoRemessa.ShipProduct(produto);  // Corrigido para acessar método estático
            System.Console.WriteLine("Pedido processado com sucesso.");
            return true;
        }
    }
}
