using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis.Extensions.Tests;

[TestClass()]
public class GanzhiNianYuesAndRiShisExtensionsTests
{
    [TestMethod()]
    public void Test()
    {
        for(int i = 0; i < 12; i++)
        {
            var tiangan = (Tiangan)i;
            Assert.IsTrue(tiangan.AsNianGetYues().SequenceEqual(new TianganNianYuesList(tiangan)));
            Assert.IsTrue(tiangan.AsRiGetShis().SequenceEqual(new TianganRiShisList(tiangan)));
        }
    }
}