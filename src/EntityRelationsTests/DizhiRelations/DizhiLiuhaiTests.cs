using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.DizhiRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using System.Reflection;

namespace YiJingFramework.EntityRelations.DizhiRelations.Tests;

[TestClass()]
public class DizhiLiuhaiTests
{
    [TestMethod()]
    public void TheCurrentTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhai(Dizhi.Zi).TheCurrent);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhai(Dizhi.Chou).TheCurrent);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhai(Dizhi.Yin).TheCurrent);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhai(Dizhi.Mao).TheCurrent);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhai(Dizhi.Chen).TheCurrent);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhai(Dizhi.Si).TheCurrent);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhai(Dizhi.Wu).TheCurrent);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhai(Dizhi.Wei).TheCurrent);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhai(Dizhi.Shen).TheCurrent);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhai(Dizhi.You).TheCurrent);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhai(Dizhi.Xu).TheCurrent);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhai(Dizhi.Hai).TheCurrent);
    }

    [TestMethod()]
    public void TheOtherTest()
    {
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhai(Dizhi.Zi).TheOther);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhai(Dizhi.Chou).TheOther);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhai(Dizhi.Yin).TheOther);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhai(Dizhi.Mao).TheOther);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhai(Dizhi.Chen).TheOther);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhai(Dizhi.Si).TheOther);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhai(Dizhi.Wu).TheOther);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhai(Dizhi.Wei).TheOther);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhai(Dizhi.Shen).TheOther);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhai(Dizhi.You).TheOther);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhai(Dizhi.Xu).TheOther);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhai(Dizhi.Hai).TheOther);
    }

    [TestMethod()]
    public void DizhiAfterChenTest()
    {
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhai(Dizhi.Zi).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhai(Dizhi.Chou).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhai(Dizhi.Yin).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhai(Dizhi.Mao).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuhai(Dizhi.Chen).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuhai(Dizhi.Si).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuhai(Dizhi.Wu).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuhai(Dizhi.Wei).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhai(Dizhi.Shen).DizhiAfterChen);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhai(Dizhi.You).DizhiAfterChen);
        Assert.AreEqual(Dizhi.You, new DizhiLiuhai(Dizhi.Xu).DizhiAfterChen);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuhai(Dizhi.Hai).DizhiAfterChen);
    }


    [TestMethod()]
    public void DizhiAfterXuTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhai(Dizhi.Zi).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhai(Dizhi.Chou).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhai(Dizhi.Yin).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhai(Dizhi.Mao).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuhai(Dizhi.Chen).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuhai(Dizhi.Si).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuhai(Dizhi.Wu).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuhai(Dizhi.Wei).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhai(Dizhi.Shen).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhai(Dizhi.You).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuhai(Dizhi.Xu).DizhiAfterXu);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuhai(Dizhi.Hai).DizhiAfterXu);
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
        foreach (var i in Enumerable.Range(1, 12).Select(x => new Dizhi(x)).Select(x => new DizhiLiuhai(x)))
        {
            Assert.AreEqual(i.DizhiAfterChen, DeterminantForSameAs(i));
        }
    }
}