using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.TianganNianYuesAndRishis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.EntityRelations.GuaHexagramBagongs;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.EntityRelations.RandomYiEntitiesGenerations.Extensions;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis.Tests;

[TestClass()]
public class TianganNianYuesListTests
{
    [TestMethod()]
    public void YueByYueTest()
    {
        void TestOn(Tiangan nian, int index, Ganzhi yue)
        {
            var list = new TianganNianYuesList(nian);
            Assert.AreEqual(yue, list[index]);
            Assert.AreEqual(yue, list[yue.Dizhi]);
            Assert.AreEqual(12, list.Count);
            Assert.AreEqual(list[index], list.ElementAt(index));
        }

        var nian = Tiangan.Jia;
        var yue = Ganzhi.FromGanzhi(Tiangan.Bing, Dizhi.Zi);
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                TestOn(nian, j, yue);
                yue = yue.Next();
            }
            nian = nian.Next();
        }
    }
}