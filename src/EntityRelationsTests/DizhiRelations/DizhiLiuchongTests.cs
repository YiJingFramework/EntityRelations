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
public class DizhiLiuchongTests
{
    [TestMethod()]
    public void DizhiLiuchongTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuchong(Dizhi.Zi).TheCurrent);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuchong(Dizhi.Chou).TheCurrent);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuchong(Dizhi.Yin).TheCurrent);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuchong(Dizhi.Mao).TheCurrent);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuchong(Dizhi.Chen).TheCurrent);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuchong(Dizhi.Si).TheCurrent);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuchong(Dizhi.Wu).TheCurrent);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuchong(Dizhi.Wei).TheCurrent);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuchong(Dizhi.Shen).TheCurrent);
        Assert.AreEqual(Dizhi.You, new DizhiLiuchong(Dizhi.You).TheCurrent);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuchong(Dizhi.Xu).TheCurrent);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuchong(Dizhi.Hai).TheCurrent);

        Assert.AreEqual(Dizhi.Wu, new DizhiLiuchong(Dizhi.Zi).TheOther);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuchong(Dizhi.Chou).TheOther);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuchong(Dizhi.Yin).TheOther);
        Assert.AreEqual(Dizhi.You, new DizhiLiuchong(Dizhi.Mao).TheOther);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuchong(Dizhi.Chen).TheOther);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuchong(Dizhi.Si).TheOther);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuchong(Dizhi.Wu).TheOther);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuchong(Dizhi.Wei).TheOther);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuchong(Dizhi.Shen).TheOther);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuchong(Dizhi.You).TheOther);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuchong(Dizhi.Xu).TheOther);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuchong(Dizhi.Hai).TheOther);

        Assert.AreEqual(Dizhi.Zi, new DizhiLiuchong(Dizhi.Zi).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuchong(Dizhi.Chou).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuchong(Dizhi.Yin).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuchong(Dizhi.Mao).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuchong(Dizhi.Chen).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuchong(Dizhi.Si).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Zi, new DizhiLiuchong(Dizhi.Wu).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Chou, new DizhiLiuchong(Dizhi.Wei).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Yin, new DizhiLiuchong(Dizhi.Shen).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Mao, new DizhiLiuchong(Dizhi.You).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Chen, new DizhiLiuchong(Dizhi.Xu).DizhiAfterZi);
        Assert.AreEqual(Dizhi.Si, new DizhiLiuchong(Dizhi.Hai).DizhiAfterZi);

        Assert.AreEqual(Dizhi.Wu, new DizhiLiuchong(Dizhi.Zi).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuchong(Dizhi.Chou).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuchong(Dizhi.Yin).DizhiAfterWu);
        Assert.AreEqual(Dizhi.You, new DizhiLiuchong(Dizhi.Mao).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuchong(Dizhi.Chen).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuchong(Dizhi.Si).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Wu, new DizhiLiuchong(Dizhi.Wu).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Wei, new DizhiLiuchong(Dizhi.Wei).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Shen, new DizhiLiuchong(Dizhi.Shen).DizhiAfterWu);
        Assert.AreEqual(Dizhi.You, new DizhiLiuchong(Dizhi.You).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Xu, new DizhiLiuchong(Dizhi.Xu).DizhiAfterWu);
        Assert.AreEqual(Dizhi.Hai, new DizhiLiuchong(Dizhi.Hai).DizhiAfterWu);

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
        foreach (var i in Enumerable.Range(1, 12).Select(x => new Dizhi(x)).Select(x => new DizhiLiuchong(x)))
        {
            Assert.AreEqual(i.DizhiAfterZi, DeterminantForSameAs(i));
        }
    }
}