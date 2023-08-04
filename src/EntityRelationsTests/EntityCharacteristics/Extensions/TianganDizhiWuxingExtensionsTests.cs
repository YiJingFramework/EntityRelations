using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions.Tests;

[TestClass()]
public class TianganDizhiWuxingExtensionsTests
{
    [TestMethod()]
    public void WuxingTest()
    {
        Assert.AreEqual(Wuxing.Wood, Tiangan.Jia.Wuxing());
        Assert.AreEqual(Wuxing.Wood, Tiangan.Yi.Wuxing());
        Assert.AreEqual(Wuxing.Fire, Tiangan.Bing.Wuxing());
        Assert.AreEqual(Wuxing.Fire, Tiangan.Ding.Wuxing());
        Assert.AreEqual(Wuxing.Earth, Tiangan.Wu.Wuxing());
        Assert.AreEqual(Wuxing.Earth, Tiangan.Ji.Wuxing());
        Assert.AreEqual(Wuxing.Metal, Tiangan.Geng.Wuxing());
        Assert.AreEqual(Wuxing.Metal, Tiangan.Xin.Wuxing());
        Assert.AreEqual(Wuxing.Water, Tiangan.Ren.Wuxing());
        Assert.AreEqual(Wuxing.Water, Tiangan.Gui.Wuxing());
    }

    [TestMethod()]
    public void WuxingTest1()
    {
        Assert.AreEqual(Wuxing.Water, Dizhi.Zi.Wuxing());
        Assert.AreEqual(Wuxing.Earth, Dizhi.Chou.Wuxing());
        Assert.AreEqual(Wuxing.Wood, Dizhi.Yin.Wuxing());
        Assert.AreEqual(Wuxing.Wood, Dizhi.Mao.Wuxing());
        Assert.AreEqual(Wuxing.Earth, Dizhi.Chen.Wuxing());
        Assert.AreEqual(Wuxing.Fire, Dizhi.Si.Wuxing());
        Assert.AreEqual(Wuxing.Fire, Dizhi.Wu.Wuxing());
        Assert.AreEqual(Wuxing.Earth, Dizhi.Wei.Wuxing());
        Assert.AreEqual(Wuxing.Metal, Dizhi.Shen.Wuxing());
        Assert.AreEqual(Wuxing.Metal, Dizhi.You.Wuxing());
        Assert.AreEqual(Wuxing.Earth, Dizhi.Xu.Wuxing());
        Assert.AreEqual(Wuxing.Water, Dizhi.Hai.Wuxing());
    }
}