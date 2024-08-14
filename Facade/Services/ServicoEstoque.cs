using Facade.Models;
using System.Collections.Generic;

namespace Facade.Services
{
    public class ServicoEstoque
    {
        private static Dictionary<int, int> estoque = new Dictionary<int, int>
        {
            { 1, 10 },  // Produto ID 1 tem 10 unidades em estoque
            { 2, 0 },   // Produto ID 2 está fora de estoque
            { 3, 5 }    // Produto ID 3 tem 5 unidades em estoque
        };

        public static bool IsAvailable(Produto product)
        {
            // Verifica se o produto está disponível no estoque
            if (estoque.ContainsKey(product.ProductId) && estoque[product.ProductId] > 0)
            {
                return true;
            }
            return false;
        }

        public static void AtualizarEstoque(Produto product)
        {
            // Reduz a quantidade no estoque após o pedido
            if (estoque.ContainsKey(product.ProductId))
            {
                estoque[product.ProductId]--;
            }
        }
    }
}
