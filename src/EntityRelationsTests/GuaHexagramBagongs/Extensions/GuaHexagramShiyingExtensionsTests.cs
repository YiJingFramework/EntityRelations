using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YiJingFramework.EntityRelations.GuaHexagramBagongs.Extensions.Tests;

[TestClass()]
public class GuaHexagramShiyingExtensionsTests
{
    [TestMethod()]
    public void ShiyaoTest()
    {
        Assert.AreEqual(5, Shiying.Bachun.Shiyao());
        Assert.AreEqual(0, Shiying.Yishi.Shiyao());
        Assert.AreEqual(1, Shiying.Ershi.Shiyao());
        Assert.AreEqual(2, Shiying.Sanshi.Shiyao());
        Assert.AreEqual(3, Shiying.Sishi.Shiyao());
        Assert.AreEqual(4, Shiying.Wushi.Shiyao());
        Assert.AreEqual(3, Shiying.Youhun.Shiyao());
        Assert.AreEqual(2, Shiying.Guihun.Shiyao());
    }

    [TestMethod()]
    public void YingyaoTest()
    {
        Assert.AreEqual(2, Shiying.Bachun.Yingyao());
        Assert.AreEqual(3, Shiying.Yishi.Yingyao());
        Assert.AreEqual(4, Shiying.Ershi.Yingyao());
        Assert.AreEqual(5, Shiying.Sanshi.Yingyao());
        Assert.AreEqual(0, Shiying.Sishi.Yingyao());
        Assert.AreEqual(1, Shiying.Wushi.Yingyao());
        Assert.AreEqual(0, Shiying.Youhun.Yingyao());
        Assert.AreEqual(5, Shiying.Guihun.Yingyao());
    }
}