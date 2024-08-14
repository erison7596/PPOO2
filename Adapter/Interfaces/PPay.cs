public interface PPay
{
    string GetCardOwnerName();
    void SetCardOwnerName(string ownerName);

    string GetCustCardNo();
    void SetCustCardNo(string cardNo);

    string GetCardExpMonthDate();
    void SetCardExpMonthDate(string expMonthDate);

    int GetCVVNo();
    void SetCVVNo(int cvvNo);

    double GetTotalAmount();
    void SetTotalAmount(double totalAmount);
}
