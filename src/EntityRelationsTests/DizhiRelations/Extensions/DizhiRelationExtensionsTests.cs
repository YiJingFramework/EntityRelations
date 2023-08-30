using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations.Extensions.Tests;

[TestClass()]
public class DizhiRelationExtensionsTests
{
    [TestMethod()]
    public void LiuchongRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiuchong(r), r.LiuchongRelation());
        }
    }

    [TestMethod()]
    public void LiuchongTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiuchong(r).TheOther, r.Liuchong());
        }
    }

    [TestMethod()]
    public void LiuhaiRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiuhai(r), r.LiuhaiRelation());
        }
    }

    [TestMethod()]
    public void LiuhaiTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiuhai(r).TheOther, r.Liuhai());
        }
    }

    [TestMethod()]
    public void LiuheRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiuhe(r), r.LiuheRelation());
        }
    }

    [TestMethod()]
    public void LiuheTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiuhe(r).TheOther, r.Liuhe());
        }
    }

    [TestMethod()]
    public void LiupoRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiupo(r), r.LiupoRelation());
        }
    }

    [TestMethod()]
    public void LiupoTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiLiupo(r).TheOther, r.Liupo());
        }
    }

    [TestMethod()]
    public void SanheRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiSanhe(r), r.SanheRelation());
        }
    }

    [TestMethod()]
    public void SanhuiRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiSanhui(r), r.SanhuiRelation());
        }
    }

    [TestMethod()]
    public void SanxingRelationTest()
    {
        for (int i = 0; i < 100; i++)
        {
            var r = (Dizhi)(Random.Shared.Next(1, 13));
            Assert.AreEqual(new DizhiSanxing(r), r.SanxingRelation());
        }
    }
}