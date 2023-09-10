using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganRelations.Tests;

[TestClass()]
public class TianganSichongTests
{
    [TestMethod()]
    public void TheCurrentTest()
    {
        Assert.AreEqual(Tiangan.Jia, new TianganSichong(Tiangan.Jia).TheCurrent);
        Assert.AreEqual(Tiangan.Yi, new TianganSichong(Tiangan.Yi).TheCurrent);
        Assert.AreEqual(Tiangan.Bing, new TianganSichong(Tiangan.Bing).TheCurrent);
        Assert.AreEqual(Tiangan.Ding, new TianganSichong(Tiangan.Ding).TheCurrent);
        _ = Assert.ThrowsException<ArgumentException>(() => new TianganSichong(Tiangan.Wu));
        _ = Assert.ThrowsException<ArgumentException>(() => new TianganSichong(Tiangan.Ji));
        Assert.AreEqual(Tiangan.Geng, new TianganSichong(Tiangan.Geng).TheCurrent);
        Assert.AreEqual(Tiangan.Xin, new TianganSichong(Tiangan.Xin).TheCurrent);
        Assert.AreEqual(Tiangan.Ren, new TianganSichong(Tiangan.Ren).TheCurrent);
        Assert.AreEqual(Tiangan.Gui, new TianganSichong(Tiangan.Gui).TheCurrent);
    }

    [TestMethod()]
    public void TheOtherTest()
    {
        Assert.AreEqual(Tiangan.Geng, new TianganSichong(Tiangan.Jia).TheOther);
        Assert.AreEqual(Tiangan.Xin, new TianganSichong(Tiangan.Yi).TheOther);
        Assert.AreEqual(Tiangan.Ren, new TianganSichong(Tiangan.Bing).TheOther);
        Assert.AreEqual(Tiangan.Gui, new TianganSichong(Tiangan.Ding).TheOther);

        Assert.AreEqual(Tiangan.Jia, new TianganSichong(Tiangan.Geng).TheOther);
        Assert.AreEqual(Tiangan.Yi, new TianganSichong(Tiangan.Xin).TheOther);
        Assert.AreEqual(Tiangan.Bing, new TianganSichong(Tiangan.Ren).TheOther);
        Assert.AreEqual(Tiangan.Ding, new TianganSichong(Tiangan.Gui).TheOther);
    }

    [TestMethod()]
    public void TianganAfterJiaTest()
    {
        Assert.AreEqual(Tiangan.Jia, new TianganSichong(Tiangan.Jia).TianganAfterJia);
        Assert.AreEqual(Tiangan.Yi, new TianganSichong(Tiangan.Yi).TianganAfterJia);
        Assert.AreEqual(Tiangan.Bing, new TianganSichong(Tiangan.Bing).TianganAfterJia);
        Assert.AreEqual(Tiangan.Ding, new TianganSichong(Tiangan.Ding).TianganAfterJia);

        Assert.AreEqual(Tiangan.Jia, new TianganSichong(Tiangan.Geng).TianganAfterJia);
        Assert.AreEqual(Tiangan.Yi, new TianganSichong(Tiangan.Xin).TianganAfterJia);
        Assert.AreEqual(Tiangan.Bing, new TianganSichong(Tiangan.Ren).TianganAfterJia);
        Assert.AreEqual(Tiangan.Ding, new TianganSichong(Tiangan.Gui).TianganAfterJia);
    }

    [TestMethod()]
    public void TianganAfterGengTest()
    {
        Assert.AreEqual(Tiangan.Geng, new TianganSichong(Tiangan.Jia).TianganAfterGeng);
        Assert.AreEqual(Tiangan.Xin, new TianganSichong(Tiangan.Yi).TianganAfterGeng);
        Assert.AreEqual(Tiangan.Ren, new TianganSichong(Tiangan.Bing).TianganAfterGeng);
        Assert.AreEqual(Tiangan.Gui, new TianganSichong(Tiangan.Ding).TianganAfterGeng);

        Assert.AreEqual(Tiangan.Geng, new TianganSichong(Tiangan.Geng).TianganAfterGeng);
        Assert.AreEqual(Tiangan.Xin, new TianganSichong(Tiangan.Xin).TianganAfterGeng);
        Assert.AreEqual(Tiangan.Ren, new TianganSichong(Tiangan.Ren).TianganAfterGeng);
        Assert.AreEqual(Tiangan.Gui, new TianganSichong(Tiangan.Gui).TianganAfterGeng);
    }

    [TestMethod()]
    public void DeterminantForSameAsTest()
    {
        static Tiangan DeterminantForSameAs<T>(TianganRelationBase<T> relation) where T : TianganRelationBase<T>
        {
            var property = relation.GetType().GetProperty(
                nameof(DeterminantForSameAs),
                BindingFlags.NonPublic | BindingFlags.Instance);
            if (property?.GetValue(relation) is not Tiangan result)
            {
                Assert.Fail();
                return default;
            }
            return result;
        }
        var tiangans = new[] { 1, 2, 3, 4, 7, 8, 9, 10 }.Select(Tiangan.FromIndex);
        foreach (var i in tiangans.Select(x => new TianganSichong(x)))
        {
            Assert.AreEqual(i.TianganAfterJia, DeterminantForSameAs(i));
        }
    }
}