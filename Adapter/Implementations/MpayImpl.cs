public class MpayImpl : MPay
{
    private string cardOwnerName;
    private string custCardNo;
    private string cardExpMonthDate;
    private int cvvNo;
    private double totalAmount;

    public string GetCardOwnerName() => cardOwnerName;
    public void SetCardOwnerName(string ownerName) => cardOwnerName = ownerName;

    public string GetCustCardNo() => custCardNo;
    public void SetCustCardNo(string cardNo) => custCardNo = cardNo;

    public string GetCardExpMonthDate() => cardExpMonthDate;
    public void SetCardExpMonthDate(string expMonthDate) => cardExpMonthDate = expMonthDate;

    public int GetCVVNo() => cvvNo;
    public void SetCVVNo(int cvvNo) => this.cvvNo = cvvNo;

    public double GetTotalAmount() => totalAmount;
    public void SetTotalAmount(double totalAmount) => this.totalAmount = totalAmount;
}
