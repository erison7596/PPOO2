namespace Facade.Models
{
    public class Produto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public Produto() { }

        public Produto(int productId, string name)
        {
            ProductId = productId;
            Name = name;
        }
    }
}
