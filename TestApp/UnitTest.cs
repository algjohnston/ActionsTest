namespace TestApp;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        App app = new();
        Assert.Equal(3, app.add(1, 2));
    }

    [Fact]
    public void FailingTest()
    {
        App app = new();
        Assert.Equal(3, app.add(1, 2));
    }
}
