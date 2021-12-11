using Xunit;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(0,1);
    }
    
    [Theory]
    [InlineData(1,1)]
    [InlineData(1,1)]
    public void Test2(int in1, int in2)
    {
        Assert.Equal(in1, in2);
    }
}