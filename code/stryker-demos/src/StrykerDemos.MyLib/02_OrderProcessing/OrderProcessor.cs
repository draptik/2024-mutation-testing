namespace StrykerDemos.MyLib._02_OrderProcessing;

public class OrderProcessor
{
    public decimal ApplyDiscount(decimal orderAmount)
    {
        if (orderAmount >= 100 && orderAmount < 500)
        {
            return orderAmount * 0.95m; // 5% discount
        }

        if (orderAmount >= 500)
        {
            return orderAmount * 0.90m; // 10% discount
        }

        return orderAmount;
    }
}