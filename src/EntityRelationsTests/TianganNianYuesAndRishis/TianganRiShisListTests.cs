using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis.Tests;

[TestClass()]
public class TianganRiShisListTests
{
    [TestMethod()]
    public void ShiByShiTest()
    {
        void TestOn(Tiangan ri, int index, Ganzhi shi)
        {
            var list = new TianganRiShisList(ri);
            Assert.AreEqual(shi, list[index]);
            Assert.AreEqual(shi, list[shi.Dizhi]);
            Assert.AreEqual(12, list.Count);
            Assert.AreEqual(list[index], list.ElementAt(index));
        }

        var ri = Tiangan.Jia;
        var shi = Ganzhi.FromGanzhi(Tiangan.Jia, Dizhi.Zi);
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                TestOn(ri, j, shi);
                shi = shi.Next();
            }
            ri = ri.Next();
        }
    }

    [TestMethod()]
    public void ComparableTest()
    {
        for (int i = 0; i < 12; i++)
        {

        }
    }
}