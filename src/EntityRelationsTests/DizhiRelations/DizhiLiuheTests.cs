using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations.Tests;

[TestClass()]
public class DizhiLiuheTests
{
    [TestMethod()]
    public void TheCurrentTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhe(Dizhi.Zi).TheCurrent);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhe(Dizhi.Chou).TheCurrent);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhe(Dizhi.Yin).TheCurrent);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhe(Dizhi.Mao).TheCurrent);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhe(Dizhi.Chen).TheCurrent);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhe(Dizhi.Si).TheCurrent);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhe(Dizhi.Wu).TheCurrent);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhe(Dizhi.Wei).TheCurrent);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhe(Dizhi.Shen).TheCurrent);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhe(Dizhi.You).TheCurrent);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhe(Dizhi.Xu).TheCurrent);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhe(Dizhi.Hai).TheCurrent);
    }
    [TestMethod()]
    public void TheOtherTest()
    {
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhe(Dizhi.Zi).TheOther);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhe(Dizhi.Chou).TheOther);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhe(Dizhi.Yin).TheOther);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhe(Dizhi.Mao).TheOther);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhe(Dizhi.Chen).TheOther);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhe(Dizhi.Si).TheOther);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhe(Dizhi.Wu).TheOther);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhe(Dizhi.Wei).TheOther);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhe(Dizhi.Shen).TheOther);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhe(Dizhi.You).TheOther);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhe(Dizhi.Xu).TheOther);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhe(Dizhi.Hai).TheOther);
    }
    [TestMethod()]
    public void DizhiAfterChouTest()
    {
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhe(Dizhi.Zi).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhe(Dizhi.Chou).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhe(Dizhi.Yin).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhe(Dizhi.Mao).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhe(Dizhi.Chen).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhe(Dizhi.Si).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhe(Dizhi.Wu).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhe(Dizhi.Wei).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhe(Dizhi.Shen).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhe(Dizhi.You).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhe(Dizhi.Xu).DizhiAfterChou);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhe(Dizhi.Hai).DizhiAfterChou);
    }
    [TestMethod()]
    public void DizhiAfterWeiTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhe(Dizhi.Zi).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhe(Dizhi.Chou).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhe(Dizhi.Yin).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhe(Dizhi.Mao).DizhiAfterWei);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhe(Dizhi.Chen).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhe(Dizhi.Si).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhe(Dizhi.Wu).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhe(Dizhi.Wei).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhe(Dizhi.Shen).DizhiAfterWei);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhe(Dizhi.You).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhe(Dizhi.Xu).DizhiAfterWei);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhe(Dizhi.Hai).DizhiAfterWei);
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
        foreach (var i in Enumerable.Range(1, 12).Select(x => (Dizhi)(x)).Select(x => new DizhiLiuhe(x)))
        {
            Assert.AreEqual(i.DizhiAfterChou, DeterminantForSameAs(i));
        }
    }
}