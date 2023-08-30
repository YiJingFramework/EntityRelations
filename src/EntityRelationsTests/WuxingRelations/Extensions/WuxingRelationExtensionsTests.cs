using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelations.Extensions.Tests;

[TestClass()]
public class WuxingRelationExtensionsTests
{
    [TestMethod()]
    public void GetRelationTest()
    {
        Assert.AreEqual(WuxingRelation.IsShengedByMe,
            Wuxing.Mu.GetRelation(Wuxing.Huo));
        Assert.AreEqual(WuxingRelation.IsShengedByMe,
            Wuxing.Huo.GetRelation(Wuxing.Tu));
        Assert.AreEqual(WuxingRelation.IsShengedByMe,
            Wuxing.Tu.GetRelation(Wuxing.Jin));
        Assert.AreEqual(WuxingRelation.IsShengedByMe,
            Wuxing.Jin.GetRelation(Wuxing.Shui));
        Assert.AreEqual(WuxingRelation.IsShengedByMe,
            Wuxing.Shui.GetRelation(Wuxing.Mu));

        Assert.AreEqual(WuxingRelation.ShengsMe,
            Wuxing.Mu.GetRelation(Wuxing.Shui));
        Assert.AreEqual(WuxingRelation.ShengsMe,
            Wuxing.Shui.GetRelation(Wuxing.Jin));
        Assert.AreEqual(WuxingRelation.ShengsMe,
            Wuxing.Jin.GetRelation(Wuxing.Tu));
        Assert.AreEqual(WuxingRelation.ShengsMe,
            Wuxing.Tu.GetRelation(Wuxing.Huo));
        Assert.AreEqual(WuxingRelation.ShengsMe,
            Wuxing.Huo.GetRelation(Wuxing.Mu));
    }

    [TestMethod()]
    public void GetWuxingTest()
    {
        for (int i = 0; i < 5; i++)
        {
            var woodP = (Wuxing)i;
            var fireP = woodP.GetWuxing(WuxingRelation.IsShengedByMe);
            var earthP = fireP.GetWuxing(WuxingRelation.IsShengedByMe);
            var metalP = earthP.GetWuxing(WuxingRelation.IsShengedByMe);
            var waterP = metalP.GetWuxing(WuxingRelation.IsShengedByMe);

            Assert.AreEqual(WuxingRelation.IsShengedByMe,
                woodP.GetRelation(fireP));
            Assert.AreEqual(WuxingRelation.IsKeedByMe,
                woodP.GetRelation(earthP));
            Assert.AreEqual(WuxingRelation.KesMe,
                woodP.GetRelation(metalP));
            Assert.AreEqual(WuxingRelation.ShengsMe,
                woodP.GetRelation(waterP));

            Assert.AreEqual(fireP,
                woodP.GetWuxing(WuxingRelation.IsShengedByMe));
            Assert.AreEqual(earthP,
                woodP.GetWuxing(WuxingRelation.IsKeedByMe));
            Assert.AreEqual(metalP,
                woodP.GetWuxing(WuxingRelation.KesMe));
            Assert.AreEqual(waterP,
                woodP.GetWuxing(WuxingRelation.ShengsMe));
        }
    }
}