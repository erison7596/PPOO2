public class MPayToPPayAdapter : PPay
{
    private readonly MPay _mPay;

    public MPayToPPayAdapter(MPay mPay)
    {
        _mPay = mPay;
    }

    public string GetCardOwnerName() => _mPay.GetCardOwnerName();
    public void SetCardOwnerName(string ownerName) => _mPay.SetCardOwnerName(ownerName);

    public string GetCustCardNo() => _mPay.GetCustCardNo();
    public void SetCustCardNo(string cardNo) => _mPay.SetCustCardNo(cardNo);

    public string GetCardExpMonthDate() => _mPay.GetCardExpMonthDate();
    public void SetCardExpMonthDate(string expMonthDate) => _mPay.SetCardExpMonthDate(expMonthDate);

    public int GetCVVNo() => _mPay.GetCVVNo();
    public void SetCVVNo(int cvvNo) => _mPay.SetCVVNo(cvvNo);

    public double GetTotalAmount() => _mPay.GetTotalAmount();
    public void SetTotalAmount(double totalAmount) => _mPay.SetTotalAmount(totalAmount);
}
