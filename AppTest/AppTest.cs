using App.BusinessLogic;

namespace AppTest;


public class UnitTest1
{
    [Fact]
    public void IncrementAdds1()
    {
        CounterService counterService = new();
        var (count, _) = counterService.Increment();
        Assert.Equal(1, count);
    }
}
