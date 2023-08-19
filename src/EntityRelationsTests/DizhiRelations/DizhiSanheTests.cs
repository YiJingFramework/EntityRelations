using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations.Tests;

[TestClass()]
public class DizhiSanheTests
{
    [TestMethod()]
    public void TheCurrentTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhe(Dizhi.Zi).TheCurrent);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhe(Dizhi.Chou).TheCurrent);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhe(Dizhi.Yin).TheCurrent);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhe(Dizhi.Mao).TheCurrent);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhe(Dizhi.Chen).TheCurrent);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhe(Dizhi.Si).TheCurrent);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhe(Dizhi.Wu).TheCurrent);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhe(Dizhi.Wei).TheCurrent);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhe(Dizhi.Shen).TheCurrent);
        Assert.AreEqual(Dizhi.You, new DizhiSanhe(Dizhi.You).TheCurrent);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhe(Dizhi.Xu).TheCurrent);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhe(Dizhi.Hai).TheCurrent);
    }

    [TestMethod()]
    public void TheNextTest()
    {
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhe(Dizhi.Zi).TheNext);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhe(Dizhi.Chou).TheNext);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhe(Dizhi.Yin).TheNext);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhe(Dizhi.Mao).TheNext);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhe(Dizhi.Chen).TheNext);
        Assert.AreEqual(Dizhi.You, new DizhiSanhe(Dizhi.Si).TheNext);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhe(Dizhi.Wu).TheNext);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhe(Dizhi.Wei).TheNext);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhe(Dizhi.Shen).TheNext);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhe(Dizhi.You).TheNext);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhe(Dizhi.Xu).TheNext);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhe(Dizhi.Hai).TheNext);
    }

    [TestMethod()]
    public void ThePreviousTest()
    {
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhe(Dizhi.Zi).ThePrevious);
        Assert.AreEqual(Dizhi.You, new DizhiSanhe(Dizhi.Chou).ThePrevious);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhe(Dizhi.Yin).ThePrevious);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhe(Dizhi.Mao).ThePrevious);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhe(Dizhi.Chen).ThePrevious);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhe(Dizhi.Si).ThePrevious);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhe(Dizhi.Wu).ThePrevious);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhe(Dizhi.Wei).ThePrevious);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhe(Dizhi.Shen).ThePrevious);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhe(Dizhi.You).ThePrevious);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhe(Dizhi.Xu).ThePrevious);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhe(Dizhi.Hai).ThePrevious);
    }

    [TestMethod()]
    public void DizhiOfZhangshengTest()
    {
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhe(Dizhi.Zi).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhe(Dizhi.Chou).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhe(Dizhi.Yin).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhe(Dizhi.Mao).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhe(Dizhi.Chen).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhe(Dizhi.Si).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhe(Dizhi.Wu).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhe(Dizhi.Wei).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhe(Dizhi.Shen).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhe(Dizhi.You).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhe(Dizhi.Xu).DizhiOfZhangsheng);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhe(Dizhi.Hai).DizhiOfZhangsheng);
    }

    [TestMethod()]
    public void DizhiOfDiwangTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhe(Dizhi.Zi).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.You, new DizhiSanhe(Dizhi.Chou).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhe(Dizhi.Yin).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhe(Dizhi.Mao).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhe(Dizhi.Chen).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.You, new DizhiSanhe(Dizhi.Si).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhe(Dizhi.Wu).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhe(Dizhi.Wei).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhe(Dizhi.Shen).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.You, new DizhiSanhe(Dizhi.You).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhe(Dizhi.Xu).DizhiOfDiwang);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhe(Dizhi.Hai).DizhiOfDiwang);
    }
    [TestMethod()]
    public void DizhiOfMuTest()
    {
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhe(Dizhi.Zi).DizhiOfMu);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhe(Dizhi.Chou).DizhiOfMu);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhe(Dizhi.Yin).DizhiOfMu);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhe(Dizhi.Mao).DizhiOfMu);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhe(Dizhi.Chen).DizhiOfMu);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhe(Dizhi.Si).DizhiOfMu);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhe(Dizhi.Wu).DizhiOfMu);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhe(Dizhi.Wei).DizhiOfMu);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhe(Dizhi.Shen).DizhiOfMu);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhe(Dizhi.You).DizhiOfMu);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhe(Dizhi.Xu).DizhiOfMu);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhe(Dizhi.Hai).DizhiOfMu);
    }

    [TestMethod()]
    public void DeterminantForSameAsTest()
    {
        static Dizhi DeterminantForSameAs<T>(DizhiRelationBase<T> relation) where T : DizhiRelationBase<T>
        {
            var property = relation.GetType().GetProperty(
                nameof(DeterminantForSameAs),
                BindingFlags.NonPublic | BindingFlags.Instance);
            if (property?.GetValue(relation) is not Dizhi result)
            {
                Assert.Fail();
                return default;
            }
            return result;
        }
        foreach (var i in Enumerable.Range(1, 12).Select(x => new Dizhi(x)).Select(x => new DizhiSanhe(x)))
        {
            Assert.AreEqual(i.DizhiOfDiwang, DeterminantForSameAs(i));
        }
    }
}