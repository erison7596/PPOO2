using Facade.Models;

namespace Facade.Services
{
    public class ServicoRemessa
    {
        public static void ShipProduct(Produto product)
        {
            // Simula o envio do produto
            System.Console.WriteLine($"Produto {product.Name} (ID: {product.ProductId}) foi enviado para o cliente.");
        }
    }
}
