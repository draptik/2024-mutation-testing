using StrykerDemos.MyLib._02_OrderProcessing;

namespace StrykerDemos.MyLib.Tests._02_OrderProcessing;

public class OrderProcessorTests
{
    [Fact]
    public void Given_order_amount_below_100_returns_no_discount_applied()
    {
        var sut = new OrderProcessor();
        var result = sut.ApplyDiscount(99);
        result.Should().Be(99);
    }

    [Fact]
    public void Given_order_amount_between_100_and_500_returns_5_percent_discount_applied()
    {
        var sut = new OrderProcessor();
        var result = sut.ApplyDiscount(200);
        result.Should().Be(190); // 200 * 0.95
    }

    [Fact]
    public void Given_order_amount_above_500_returns_10_percent_discount_applied()
    {
        var sut = new OrderProcessor();
        var result = sut.ApplyDiscount(600);
        result.Should().Be(540); // 600 * 0.90
    }
}