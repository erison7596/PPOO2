namespace Facade.Services
{
    public class ServicoPagamento
    {
        public static bool MakePayment()
        {
            // Simula o sucesso do pagamento 90% das vezes
            Random rnd = new Random();
            int resultado = rnd.Next(1, 101); 

            return resultado <= 90;  // 90% de chance de sucesso no pagamento
        }
    }
}
