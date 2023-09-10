using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganRelations.Extensions.Tests;

[TestClass()]
public class TianganRelationExtensionsTests
{
    [TestMethod()]
    public void SichongRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = Tiangan.FromIndex(Random.Shared.Next(1, 11));
            try
            {
                Assert.AreEqual(new TianganSichong(r), r.SichongRelation());
            }
            catch (ArgumentException)
            {
                Assert.AreEqual(null, r.SichongRelation());
            }
        }
    }

    [TestMethod()]
    public void SichongTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = Tiangan.FromIndex(Random.Shared.Next(1, 11));
            try
            {
                Assert.AreEqual(new TianganSichong(r).TheOther, r.Sichong());
            }
            catch (ArgumentException)
            {
                Assert.AreEqual(null, r.Sichong());
            }
        }
    }

    [TestMethod()]
    public void WuheRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = Tiangan.FromIndex(Random.Shared.Next(1, 11));
            Assert.AreEqual(new TianganWuhe(r), r.WuheRelation());
        }
    }

    [TestMethod()]
    public void WuheTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = Tiangan.FromIndex(Random.Shared.Next(1, 11));
            Assert.AreEqual(new TianganWuhe(r).TheOther, r.Wuhe());
        }
    }
}