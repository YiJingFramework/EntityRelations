using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.RandomYiEntitiesGenerations.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.RandomYiEntitiesGenerations.Extensions.Tests;

[TestClass()]
public class RandomYiEntitiesGenerationExtensionsTests
{
    private static void TestRandomIntegerLike<T>(
        Func<Random, T> function,
        int countOfAllPossibleResults)
    {
        var random = new Random(1234);
        var set = new HashSet<T>();

        var times = 0;
        for (; ; )
        {
            times++;
            var value = function(random);
            _ = set.Add(value);
            if (set.Count == countOfAllPossibleResults)
                break;
            if (times > 10000)
                break;
        }

        Assert.AreEqual(countOfAllPossibleResults, set.Count);
        Assert.IsTrue(times <= 10000);
    }

    [TestMethod()]
    public void NextTianganTest()
    {
        TestRandomIntegerLike(RandomYiEntitiesGenerationExtensions.NextTiangan, 10);
    }

    [TestMethod()]
    public void NextDizhiTest()
    {
        TestRandomIntegerLike(RandomYiEntitiesGenerationExtensions.NextDizhi, 12);
    }

    [TestMethod()]
    public void NextGanzhiTest()
    {
        TestRandomIntegerLike(RandomYiEntitiesGenerationExtensions.NextGanzhi, 60);
    }

    [TestMethod()]
    public void NextYinyangTest()
    {
        TestRandomIntegerLike(RandomYiEntitiesGenerationExtensions.NextYinyang, 2);
    }

    [TestMethod()]
    public void NextGuaHexagramTest()
    {
        TestRandomIntegerLike(RandomYiEntitiesGenerationExtensions.NextGuaHexagram, 64);
    }

    [TestMethod()]
    public void NextGuaTrigramTest()
    {
        TestRandomIntegerLike(RandomYiEntitiesGenerationExtensions.NextGuaTrigram, 8);
    }
}