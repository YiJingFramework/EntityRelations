using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.DizhiRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations.Tests;

[TestClass()]
public class DizhiSanhuiTests
{
    [TestMethod()]
    public void TheCurrentTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhui(Dizhi.Zi).TheCurrent);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhui(Dizhi.Chou).TheCurrent);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhui(Dizhi.Yin).TheCurrent);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhui(Dizhi.Mao).TheCurrent);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhui(Dizhi.Chen).TheCurrent);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhui(Dizhi.Si).TheCurrent);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhui(Dizhi.Wu).TheCurrent);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhui(Dizhi.Wei).TheCurrent);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhui(Dizhi.Shen).TheCurrent);
        Assert.AreEqual(Dizhi.You, new DizhiSanhui(Dizhi.You).TheCurrent);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhui(Dizhi.Xu).TheCurrent);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhui(Dizhi.Hai).TheCurrent);
    }

    [TestMethod()]
    public void TheOthersTest()
    {
        Assert.AreEqual((Dizhi.Hai, Dizhi.Chou), new DizhiSanhui(Dizhi.Zi).TheOthers);
        Assert.AreEqual((Dizhi.Hai, Dizhi.Zi), new DizhiSanhui(Dizhi.Chou).TheOthers);
        Assert.AreEqual((Dizhi.Mao, Dizhi.Chen), new DizhiSanhui(Dizhi.Yin).TheOthers);
        Assert.AreEqual((Dizhi.Yin, Dizhi.Chen), new DizhiSanhui(Dizhi.Mao).TheOthers);
        Assert.AreEqual((Dizhi.Yin, Dizhi.Mao), new DizhiSanhui(Dizhi.Chen).TheOthers);
        Assert.AreEqual((Dizhi.Wu, Dizhi.Wei), new DizhiSanhui(Dizhi.Si).TheOthers);
        Assert.AreEqual((Dizhi.Si, Dizhi.Wei), new DizhiSanhui(Dizhi.Wu).TheOthers);
        Assert.AreEqual((Dizhi.Si, Dizhi.Wu), new DizhiSanhui(Dizhi.Wei).TheOthers);
        Assert.AreEqual((Dizhi.You, Dizhi.Xu), new DizhiSanhui(Dizhi.Shen).TheOthers);
        Assert.AreEqual((Dizhi.Shen, Dizhi.Xu), new DizhiSanhui(Dizhi.You).TheOthers);
        Assert.AreEqual((Dizhi.Shen, Dizhi.You), new DizhiSanhui(Dizhi.Xu).TheOthers);
        Assert.AreEqual((Dizhi.Zi, Dizhi.Chou), new DizhiSanhui(Dizhi.Hai).TheOthers);
    }

    [TestMethod()]
    public void DizhiOfMengTest()
    {
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhui(Dizhi.Zi).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhui(Dizhi.Chou).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhui(Dizhi.Yin).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhui(Dizhi.Mao).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Yin, new DizhiSanhui(Dizhi.Chen).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhui(Dizhi.Si).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhui(Dizhi.Wu).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Si, new DizhiSanhui(Dizhi.Wei).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhui(Dizhi.Shen).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhui(Dizhi.You).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Shen, new DizhiSanhui(Dizhi.Xu).DizhiOfMeng);
        Assert.AreEqual(Dizhi.Hai, new DizhiSanhui(Dizhi.Hai).DizhiOfMeng);
    }

    [TestMethod()]
    public void DizhiOfZhongTest()
    {
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhui(Dizhi.Zi).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhui(Dizhi.Chou).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhui(Dizhi.Yin).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhui(Dizhi.Mao).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Mao, new DizhiSanhui(Dizhi.Chen).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhui(Dizhi.Si).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhui(Dizhi.Wu).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Wu, new DizhiSanhui(Dizhi.Wei).DizhiOfZhong);
        Assert.AreEqual(Dizhi.You, new DizhiSanhui(Dizhi.Shen).DizhiOfZhong);
        Assert.AreEqual(Dizhi.You, new DizhiSanhui(Dizhi.You).DizhiOfZhong);
        Assert.AreEqual(Dizhi.You, new DizhiSanhui(Dizhi.Xu).DizhiOfZhong);
        Assert.AreEqual(Dizhi.Zi, new DizhiSanhui(Dizhi.Hai).DizhiOfZhong);
    }


    [TestMethod()]
    public void DizhiOfJiTest()
    {
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhui(Dizhi.Zi).DizhiOfJi);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhui(Dizhi.Chou).DizhiOfJi);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhui(Dizhi.Yin).DizhiOfJi);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhui(Dizhi.Mao).DizhiOfJi);
        Assert.AreEqual(Dizhi.Chen, new DizhiSanhui(Dizhi.Chen).DizhiOfJi);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhui(Dizhi.Si).DizhiOfJi);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhui(Dizhi.Wu).DizhiOfJi);
        Assert.AreEqual(Dizhi.Wei, new DizhiSanhui(Dizhi.Wei).DizhiOfJi);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhui(Dizhi.Shen).DizhiOfJi);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhui(Dizhi.You).DizhiOfJi);
        Assert.AreEqual(Dizhi.Xu, new DizhiSanhui(Dizhi.Xu).DizhiOfJi);
        Assert.AreEqual(Dizhi.Chou, new DizhiSanhui(Dizhi.Hai).DizhiOfJi);
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
        foreach (var i in Enumerable.Range(1, 12).Select(x => new Dizhi(x)).Select(x => new DizhiSanhui(x)))
        {
            Assert.AreEqual(i.DizhiOfZhong, DeterminantForSameAs(i));
        }
    }
}