using Xunit;
public class SimpleTest
{
    [Fact]
    public void SimpleStringCompare()
    { 
        #if NET6_0
            Assert.Equal("value", "value2");
        #else
            Assert.Equal("value", "value");
        #endif
        
    }
}