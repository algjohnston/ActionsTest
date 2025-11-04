namespace MyTestProject;

using MyMauiApp;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(3, Adder.Add(1, 2));
        Adder adder = new Adder();
        adder.StoreAdd(4, 5);
        Assert.Equal(9, adder.GetStoredAdd());
    }
}
