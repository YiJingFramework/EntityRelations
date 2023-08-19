using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganRelations.Tests;

[TestClass()]
public class TianganWuheTests
{
    [TestMethod()]
    public void TheCurrentTest()
    {
        Assert.AreEqual(Tiangan.Jia, new TianganWuhe(Tiangan.Jia).TheCurrent);
        Assert.AreEqual(Tiangan.Yi, new TianganWuhe(Tiangan.Yi).TheCurrent);
        Assert.AreEqual(Tiangan.Bing, new TianganWuhe(Tiangan.Bing).TheCurrent);
        Assert.AreEqual(Tiangan.Ding, new TianganWuhe(Tiangan.Ding).TheCurrent);
        Assert.AreEqual(Tiangan.Wu, new TianganWuhe(Tiangan.Wu).TheCurrent);
        Assert.AreEqual(Tiangan.Ji, new TianganWuhe(Tiangan.Ji).TheCurrent);
        Assert.AreEqual(Tiangan.Geng, new TianganWuhe(Tiangan.Geng).TheCurrent);
        Assert.AreEqual(Tiangan.Xin, new TianganWuhe(Tiangan.Xin).TheCurrent);
        Assert.AreEqual(Tiangan.Ren, new TianganWuhe(Tiangan.Ren).TheCurrent);
        Assert.AreEqual(Tiangan.Gui, new TianganWuhe(Tiangan.Gui).TheCurrent);
    }

    [TestMethod()]
    public void TheOtherTest()
    {
        Assert.AreEqual(Tiangan.Ji, new TianganWuhe(Tiangan.Jia).TheOther);
        Assert.AreEqual(Tiangan.Geng, new TianganWuhe(Tiangan.Yi).TheOther);
        Assert.AreEqual(Tiangan.Xin, new TianganWuhe(Tiangan.Bing).TheOther);
        Assert.AreEqual(Tiangan.Ren, new TianganWuhe(Tiangan.Ding).TheOther);
        Assert.AreEqual(Tiangan.Gui, new TianganWuhe(Tiangan.Wu).TheOther);
        Assert.AreEqual(Tiangan.Jia, new TianganWuhe(Tiangan.Ji).TheOther);
        Assert.AreEqual(Tiangan.Yi, new TianganWuhe(Tiangan.Geng).TheOther);
        Assert.AreEqual(Tiangan.Bing, new TianganWuhe(Tiangan.Xin).TheOther);
        Assert.AreEqual(Tiangan.Ding, new TianganWuhe(Tiangan.Ren).TheOther);
        Assert.AreEqual(Tiangan.Wu, new TianganWuhe(Tiangan.Gui).TheOther);
    }

    [TestMethod()]
    public void TianganAfterJiaTest()
    {
        Assert.AreEqual(Tiangan.Jia, new TianganWuhe(Tiangan.Jia).TianganAfterJia);
        Assert.AreEqual(Tiangan.Yi, new TianganWuhe(Tiangan.Yi).TianganAfterJia);
        Assert.AreEqual(Tiangan.Bing, new TianganWuhe(Tiangan.Bing).TianganAfterJia);
        Assert.AreEqual(Tiangan.Ding, new TianganWuhe(Tiangan.Ding).TianganAfterJia);
        Assert.AreEqual(Tiangan.Wu, new TianganWuhe(Tiangan.Wu).TianganAfterJia);
        Assert.AreEqual(Tiangan.Jia, new TianganWuhe(Tiangan.Ji).TianganAfterJia);
        Assert.AreEqual(Tiangan.Yi, new TianganWuhe(Tiangan.Geng).TianganAfterJia);
        Assert.AreEqual(Tiangan.Bing, new TianganWuhe(Tiangan.Xin).TianganAfterJia);
        Assert.AreEqual(Tiangan.Ding, new TianganWuhe(Tiangan.Ren).TianganAfterJia);
        Assert.AreEqual(Tiangan.Wu, new TianganWuhe(Tiangan.Gui).TianganAfterJia);
    }


    [TestMethod()]
    public void TianganAfterJiTest()
    {
        Assert.AreEqual(Tiangan.Ji, new TianganWuhe(Tiangan.Jia).TianganAfterJi);
        Assert.AreEqual(Tiangan.Geng, new TianganWuhe(Tiangan.Yi).TianganAfterJi);
        Assert.AreEqual(Tiangan.Xin, new TianganWuhe(Tiangan.Bing).TianganAfterJi);
        Assert.AreEqual(Tiangan.Ren, new TianganWuhe(Tiangan.Ding).TianganAfterJi);
        Assert.AreEqual(Tiangan.Gui, new TianganWuhe(Tiangan.Wu).TianganAfterJi);
        Assert.AreEqual(Tiangan.Ji, new TianganWuhe(Tiangan.Ji).TianganAfterJi);
        Assert.AreEqual(Tiangan.Geng, new TianganWuhe(Tiangan.Geng).TianganAfterJi);
        Assert.AreEqual(Tiangan.Xin, new TianganWuhe(Tiangan.Xin).TianganAfterJi);
        Assert.AreEqual(Tiangan.Ren, new TianganWuhe(Tiangan.Ren).TianganAfterJi);
        Assert.AreEqual(Tiangan.Gui, new TianganWuhe(Tiangan.Gui).TianganAfterJi);
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
        foreach (var i in Enumerable.Range(1, 10).Select(x => new Tiangan(x)).Select(x => new TianganWuhe(x)))
        {
            Assert.AreEqual(i.TianganAfterJia, DeterminantForSameAs(i));
        }
    }
}