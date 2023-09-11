using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions.Tests;

[TestClass()]
public class TianganDizhiYinyangExtensionsTests
{
    [TestMethod()]
    public void YinyangTest()
    {
        Assert.AreEqual(Yinyang.Yang, Tiangan.Jia.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Yi.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Bing.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Ding.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Wu.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Ji.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Geng.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Xin.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Tiangan.Ren.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Tiangan.Gui.Yinyang());
    }

    [TestMethod()]
    public void YinyangTest1()
    {
        Assert.AreEqual(Yinyang.Yang, Dizhi.Zi.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Chou.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Yin.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Mao.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Chen.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Si.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Wu.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Wei.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Shen.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Dizhi.You.Yinyang());
        Assert.AreEqual(Yinyang.Yang, Dizhi.Xu.Yinyang());
        Assert.AreEqual(Yinyang.Yin, Dizhi.Hai.Yinyang());
    }

    [TestMethod()]
    public void YinyangTest2()
    {
        for (int i = 0; i < 10; i++)
        {
            var tiangan = (Tiangan)i;
            Assert.AreEqual(tiangan.Yinyang(), new TianganOrDizhi(tiangan).Yinyang());
        }
        for (int i = 0; i < 12; i++)
        {
            var dizhi = (Dizhi)i;
            Assert.AreEqual(dizhi.Yinyang(), new TianganOrDizhi(dizhi).Yinyang());
        }
    }

    [TestMethod()]
    public void YinyangTest3()
    {
        for (int i = 0; i < 60; i++)
        {
            var ganzhi = Ganzhi.FromIndex(i);
            Assert.AreEqual(ganzhi.Tiangan.Yinyang(), ganzhi.Yinyang());
            Assert.AreEqual(ganzhi.Dizhi.Yinyang(), ganzhi.Yinyang());
        }
    }
}