using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelations.Extensions.Tests;

[TestClass()]
public class WuxingRelationExtensionsTests
{
    [TestMethod()]
    public void GetRelationTest()
    {
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Wood.GetRelation(Wuxing.Fire));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Fire.GetRelation(Wuxing.Earth));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Earth.GetRelation(Wuxing.Metal));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Metal.GetRelation(Wuxing.Water));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Water.GetRelation(Wuxing.Wood));

        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Wood.GetRelation(Wuxing.Water));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Water.GetRelation(Wuxing.Metal));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Metal.GetRelation(Wuxing.Earth));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Earth.GetRelation(Wuxing.Fire));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Fire.GetRelation(Wuxing.Wood));
    }

    [TestMethod()]
    public void GetWuxingTest()
    {
        for (int i = 0; i < 5; i++)
        {
            var woodP = (Wuxing)i;
            var fireP = woodP.GetWuxing(WuxingRelation.GeneratedByMe);
            var earthP = fireP.GetWuxing(WuxingRelation.GeneratedByMe);
            var metalP = earthP.GetWuxing(WuxingRelation.GeneratedByMe);
            var waterP = metalP.GetWuxing(WuxingRelation.GeneratedByMe);

            Assert.AreEqual(WuxingRelation.GeneratedByMe,
                woodP.GetRelation(fireP));
            Assert.AreEqual(WuxingRelation.OvercameByMe,
                woodP.GetRelation(earthP));
            Assert.AreEqual(WuxingRelation.OvercomingMe,
                woodP.GetRelation(metalP));
            Assert.AreEqual(WuxingRelation.GeneratingMe,
                woodP.GetRelation(waterP));

            Assert.AreEqual(fireP,
                woodP.GetWuxing(WuxingRelation.GeneratedByMe));
            Assert.AreEqual(earthP,
                woodP.GetWuxing(WuxingRelation.OvercameByMe));
            Assert.AreEqual(metalP,
                woodP.GetWuxing(WuxingRelation.OvercomingMe));
            Assert.AreEqual(waterP,
                woodP.GetWuxing(WuxingRelation.GeneratingMe));
        }
    }
}