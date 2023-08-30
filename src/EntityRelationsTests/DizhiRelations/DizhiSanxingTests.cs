using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations.Tests;

[TestClass()]
public class DizhiSanxingTests
{
    [TestMethod()]
    public void TheCurrentTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiSanxing(Dizhi.Zi).TheCurrent);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanxing(Dizhi.Chou).TheCurrent);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanxing(Dizhi.Yin).TheCurrent);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanxing(Dizhi.Mao).TheCurrent);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanxing(Dizhi.Chen).TheCurrent);
        Assert.AreEqual(Dizhi.Si, new DizhiSanxing(Dizhi.Si).TheCurrent);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanxing(Dizhi.Wu).TheCurrent);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanxing(Dizhi.Wei).TheCurrent);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanxing(Dizhi.Shen).TheCurrent);
        Assert.AreEqual(Dizhi.You, new DizhiSanxing(Dizhi.You).TheCurrent);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanxing(Dizhi.Xu).TheCurrent);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanxing(Dizhi.Hai).TheCurrent);
    }

    [TestMethod()]
    public void TheNextTest()
    {
        Assert.AreEqual(Dizhi.Mao, new DizhiSanxing(Dizhi.Zi).TheNext);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanxing(Dizhi.Chou).TheNext);
        Assert.AreEqual(Dizhi.Si, new DizhiSanxing(Dizhi.Yin).TheNext);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanxing(Dizhi.Mao).TheNext);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanxing(Dizhi.Chen).TheNext);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanxing(Dizhi.Si).TheNext);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanxing(Dizhi.Wu).TheNext);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanxing(Dizhi.Wei).TheNext);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanxing(Dizhi.Shen).TheNext);
        Assert.AreEqual(Dizhi.You, new DizhiSanxing(Dizhi.You).TheNext);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanxing(Dizhi.Xu).TheNext);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanxing(Dizhi.Hai).TheNext);
    }

    [TestMethod()]
    public void ThePreviousTest()
    {
        Assert.AreEqual(Dizhi.Mao, new DizhiSanxing(Dizhi.Zi).ThePrevious);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanxing(Dizhi.Chou).ThePrevious);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanxing(Dizhi.Yin).ThePrevious);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanxing(Dizhi.Mao).ThePrevious);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanxing(Dizhi.Chen).ThePrevious);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanxing(Dizhi.Si).ThePrevious);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanxing(Dizhi.Wu).ThePrevious);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanxing(Dizhi.Wei).ThePrevious);
        Assert.AreEqual(Dizhi.Si, new DizhiSanxing(Dizhi.Shen).ThePrevious);
        Assert.AreEqual(Dizhi.You, new DizhiSanxing(Dizhi.You).ThePrevious);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanxing(Dizhi.Xu).ThePrevious);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanxing(Dizhi.Hai).ThePrevious);
    }

    [TestMethod()]
    public void DizhisTest()
    {
        static void AssertSequence<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            using var e = expected.GetEnumerator();
            using var a = actual.GetEnumerator();
            for (; e.MoveNext();)
            {
                Assert.IsTrue(a.MoveNext());
                Assert.AreEqual(e.Current, a.Current);
            }
            Assert.IsFalse(a.MoveNext());
        }
        var ziMao = new[] { Dizhi.Zi, Dizhi.Mao };
        var chouXuWei = new[] { Dizhi.Chou, Dizhi.Xu, Dizhi.Wei };
        var yinSiShen = new[] { Dizhi.Yin, Dizhi.Si, Dizhi.Shen };

        AssertSequence(ziMao, new DizhiSanxing(Dizhi.Zi).Dizhis);
        AssertSequence(chouXuWei, new DizhiSanxing(Dizhi.Chou).Dizhis);
        AssertSequence(yinSiShen, new DizhiSanxing(Dizhi.Yin).Dizhis);
        AssertSequence(ziMao, new DizhiSanxing(Dizhi.Mao).Dizhis);
        AssertSequence(new[] { Dizhi.Chen }, new DizhiSanxing(Dizhi.Chen).Dizhis);
        AssertSequence(yinSiShen, new DizhiSanxing(Dizhi.Si).Dizhis);
        AssertSequence(new[] { Dizhi.Wu }, new DizhiSanxing(Dizhi.Wu).Dizhis);
        AssertSequence(chouXuWei, new DizhiSanxing(Dizhi.Wei).Dizhis);
        AssertSequence(yinSiShen, new DizhiSanxing(Dizhi.Shen).Dizhis);
        AssertSequence(new[] { Dizhi.You }, new DizhiSanxing(Dizhi.You).Dizhis);
        AssertSequence(chouXuWei, new DizhiSanxing(Dizhi.Xu).Dizhis);
        AssertSequence(new[] { Dizhi.Hai }, new DizhiSanxing(Dizhi.Hai).Dizhis);
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
        foreach (var i in Enumerable.Range(1, 12).Select(x => (Dizhi)(x)).Select(x => new DizhiSanxing(x)))
        {
            Assert.AreEqual(i.Dizhis[0], DeterminantForSameAs(i));
        }
    }
}