using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions.Tests;

[TestClass()]
public class TianganDizhiWuxingExtensionsTests
{
    [TestMethod()]
    public void WuxingTest()
    {
        Assert.AreEqual(Wuxing.Mu, Tiangan.Jia.Wuxing());
        Assert.AreEqual(Wuxing.Mu, Tiangan.Yi.Wuxing());
        Assert.AreEqual(Wuxing.Huo, Tiangan.Bing.Wuxing());
        Assert.AreEqual(Wuxing.Huo, Tiangan.Ding.Wuxing());
        Assert.AreEqual(Wuxing.Tu, Tiangan.Wu.Wuxing());
        Assert.AreEqual(Wuxing.Tu, Tiangan.Ji.Wuxing());
        Assert.AreEqual(Wuxing.Jin, Tiangan.Geng.Wuxing());
        Assert.AreEqual(Wuxing.Jin, Tiangan.Xin.Wuxing());
        Assert.AreEqual(Wuxing.Shui, Tiangan.Ren.Wuxing());
        Assert.AreEqual(Wuxing.Shui, Tiangan.Gui.Wuxing());
    }

    [TestMethod()]
    public void WuxingTest1()
    {
        Assert.AreEqual(Wuxing.Shui, Dizhi.Zi.Wuxing());
        Assert.AreEqual(Wuxing.Tu, Dizhi.Chou.Wuxing());
        Assert.AreEqual(Wuxing.Mu, Dizhi.Yin.Wuxing());
        Assert.AreEqual(Wuxing.Mu, Dizhi.Mao.Wuxing());
        Assert.AreEqual(Wuxing.Tu, Dizhi.Chen.Wuxing());
        Assert.AreEqual(Wuxing.Huo, Dizhi.Si.Wuxing());
        Assert.AreEqual(Wuxing.Huo, Dizhi.Wu.Wuxing());
        Assert.AreEqual(Wuxing.Tu, Dizhi.Wei.Wuxing());
        Assert.AreEqual(Wuxing.Jin, Dizhi.Shen.Wuxing());
        Assert.AreEqual(Wuxing.Jin, Dizhi.You.Wuxing());
        Assert.AreEqual(Wuxing.Tu, Dizhi.Xu.Wuxing());
        Assert.AreEqual(Wuxing.Shui, Dizhi.Hai.Wuxing());
    }
}