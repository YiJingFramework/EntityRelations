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
public class DizhiLiupoTests
{
    [TestMethod()]
    public void DizhiLiupoTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiLiupo(Dizhi.Zi).TheCurrent);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiupo(Dizhi.Chou).TheCurrent);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiupo(Dizhi.Yin).TheCurrent);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiupo(Dizhi.Mao).TheCurrent);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiupo(Dizhi.Chen).TheCurrent);
        Assert.AreEqual(Dizhi.Si, new DizhiLiupo(Dizhi.Si).TheCurrent);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiupo(Dizhi.Wu).TheCurrent);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiupo(Dizhi.Wei).TheCurrent);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiupo(Dizhi.Shen).TheCurrent);
        Assert.AreEqual(Dizhi.You, new DizhiLiupo(Dizhi.You).TheCurrent);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiupo(Dizhi.Xu).TheCurrent);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiupo(Dizhi.Hai).TheCurrent);

        Assert.AreEqual(Dizhi.You, new DizhiLiupo(Dizhi.Zi).TheOther);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiupo(Dizhi.Chou).TheOther);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiupo(Dizhi.Yin).TheOther);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiupo(Dizhi.Mao).TheOther);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiupo(Dizhi.Chen).TheOther);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiupo(Dizhi.Si).TheOther);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiupo(Dizhi.Wu).TheOther);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiupo(Dizhi.Wei).TheOther);
        Assert.AreEqual(Dizhi.Si, new DizhiLiupo(Dizhi.Shen).TheOther);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiupo(Dizhi.You).TheOther);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiupo(Dizhi.Xu).TheOther);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiupo(Dizhi.Hai).TheOther);

        Assert.AreEqual(Dizhi.You, new DizhiLiupo(Dizhi.Zi).DizhiOfYin);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiupo(Dizhi.Chou).DizhiOfYin);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiupo(Dizhi.Yin).DizhiOfYin);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiupo(Dizhi.Mao).DizhiOfYin);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiupo(Dizhi.Chen).DizhiOfYin);
        Assert.AreEqual(Dizhi.Si, new DizhiLiupo(Dizhi.Si).DizhiOfYin);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiupo(Dizhi.Wu).DizhiOfYin);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiupo(Dizhi.Wei).DizhiOfYin);
        Assert.AreEqual(Dizhi.Si, new DizhiLiupo(Dizhi.Shen).DizhiOfYin);
        Assert.AreEqual(Dizhi.You, new DizhiLiupo(Dizhi.You).DizhiOfYin);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiupo(Dizhi.Xu).DizhiOfYin);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiupo(Dizhi.Hai).DizhiOfYin);

        Assert.AreEqual(Dizhi.Zi, new DizhiLiupo(Dizhi.Zi).DizhiOfYang);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiupo(Dizhi.Chou).DizhiOfYang);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiupo(Dizhi.Yin).DizhiOfYang);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiupo(Dizhi.Mao).DizhiOfYang);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiupo(Dizhi.Chen).DizhiOfYang);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiupo(Dizhi.Si).DizhiOfYang);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiupo(Dizhi.Wu).DizhiOfYang);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiupo(Dizhi.Wei).DizhiOfYang);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiupo(Dizhi.Shen).DizhiOfYang);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiupo(Dizhi.You).DizhiOfYang);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiupo(Dizhi.Xu).DizhiOfYang);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiupo(Dizhi.Hai).DizhiOfYang);

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
        foreach (var i in Enumerable.Range(1, 12).Select(x => new Dizhi(x)).Select(x => new DizhiLiupo(x)))
        {
            Assert.AreEqual(i.DizhiOfYang, DeterminantForSameAs(i));
        }
    }
}