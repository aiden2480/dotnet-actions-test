using NUnit.Framework;

namespace DotNetApp.Test;

public class Tests
{
    [Test]
    public void TestPass()
    {
        Assert.Pass();
    }

    [Test]
    public void TestFail()
    {
        Assert.Fail();
    }
}
