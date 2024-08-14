using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Cria um objeto MPay
        MPay mPay = new MpayImpl();
        mPay.SetCardOwnerName("John Doe");
        mPay.SetCustCardNo("1234567890123456");
        mPay.SetCardExpMonthDate("12/25");
        mPay.SetCVVNo(123);
        mPay.SetTotalAmount(100.50);

        // Usa o adaptador para converter MPay para PPay
        PPay pPay = new MPayToPPayAdapter(mPay);

        // Testa a implementação PPay
        testPPay(pPay);
    }

    public static void testPPay(PPay pp)
    {
        Console.WriteLine(pp.GetCardOwnerName());
        Console.WriteLine(pp.GetCustCardNo());
        Console.WriteLine(pp.GetCardExpMonthDate());
        Console.WriteLine(pp.GetCVVNo());
        Console.WriteLine(pp.GetTotalAmount());
    }
}
