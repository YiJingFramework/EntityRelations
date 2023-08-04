using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.Shared;
using YiJingFramework.EntityRelations.WuxingRelationshipExtensions;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelationshipExtensions.Tests;

[TestClass()]
public class WuxingRelationshipExtensionsTests
{
    [TestMethod()]
    public void GetWuxingRelationshipTest()
    {
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Wood.GetWuxingRelationship(Wuxing.Fire));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Fire.GetWuxingRelationship(Wuxing.Earth));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Earth.GetWuxingRelationship(Wuxing.Metal));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Metal.GetWuxingRelationship(Wuxing.Water));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Water.GetWuxingRelationship(Wuxing.Wood));

        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Wood.GetWuxingRelationship(Wuxing.Water));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Water.GetWuxingRelationship(Wuxing.Metal));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Metal.GetWuxingRelationship(Wuxing.Earth));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Earth.GetWuxingRelationship(Wuxing.Fire));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Fire.GetWuxingRelationship(Wuxing.Wood));
    }

    [TestMethod()]
    public void GetWuxingThatTest()
    {
        for (int i = 0; i < 5; i++)
        {
            var woodP = (Wuxing)i;
            var fireP = woodP.GetWuxingThat(WuxingRelationship.GeneratedByMe);
            var earthP = fireP.GetWuxingThat(WuxingRelationship.GeneratedByMe);
            var metalP = earthP.GetWuxingThat(WuxingRelationship.GeneratedByMe);
            var waterP = metalP.GetWuxingThat(WuxingRelationship.GeneratedByMe);

            Assert.AreEqual(WuxingRelationship.GeneratedByMe,
                woodP.GetWuxingRelationship(fireP));
            Assert.AreEqual(WuxingRelationship.OvercameByMe,
                woodP.GetWuxingRelationship(earthP));
            Assert.AreEqual(WuxingRelationship.OvercomingMe,
                woodP.GetWuxingRelationship(metalP));
            Assert.AreEqual(WuxingRelationship.GeneratingMe,
                woodP.GetWuxingRelationship(waterP));

            Assert.AreEqual(fireP,
                woodP.GetWuxingThat(WuxingRelationship.GeneratedByMe));
            Assert.AreEqual(earthP,
                woodP.GetWuxingThat(WuxingRelationship.OvercameByMe));
            Assert.AreEqual(metalP,
                woodP.GetWuxingThat(WuxingRelationship.OvercomingMe));
            Assert.AreEqual(waterP,
                woodP.GetWuxingThat(WuxingRelationship.GeneratingMe));
        }
    }


    [TestMethod()]
    public void ToStringTest()
    {
        Assert.AreEqual(
            WuxingRelationship.GeneratingMe.ToString(), 
            WuxingRelationship.GeneratingMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelationship.GeneratedByMe.ToString(),
            WuxingRelationship.GeneratedByMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelationship.OvercameByMe.ToString(),
            WuxingRelationship.OvercameByMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelationship.OvercomingMe.ToString(),
            WuxingRelationship.OvercomingMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelationship.SameAsMe.ToString(),
            WuxingRelationship.SameAsMe.ToString(conversion: null));
        Assert.AreEqual(
            ((WuxingRelationship)100).ToString(),
            ((WuxingRelationship)100).ToString(conversion: null));

        var c = WuxingRelationshipToStringConversions.InChinese;
        Assert.AreEqual("生我", WuxingRelationship.GeneratingMe.ToString(c));
        Assert.AreEqual("我生", WuxingRelationship.GeneratedByMe.ToString(c));
        Assert.AreEqual("我克", WuxingRelationship.OvercameByMe.ToString(c));
        Assert.AreEqual("克我", WuxingRelationship.OvercomingMe.ToString(c));
        Assert.AreEqual("同我", WuxingRelationship.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelationship)100).ToString(c));

        c = WuxingRelationshipToStringConversions.Liuqin;
        Assert.AreEqual("父母", WuxingRelationship.GeneratingMe.ToString(c));
        Assert.AreEqual("子孙", WuxingRelationship.GeneratedByMe.ToString(c));
        Assert.AreEqual("妻财", WuxingRelationship.OvercameByMe.ToString(c));
        Assert.AreEqual("官鬼", WuxingRelationship.OvercomingMe.ToString(c));
        Assert.AreEqual("兄弟", WuxingRelationship.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelationship)100).ToString(c));

        c = WuxingRelationshipToStringConversions.LiuqinInEnglish;
        Assert.AreEqual("Parent", WuxingRelationship.GeneratingMe.ToString(c));
        Assert.AreEqual("Offspring", WuxingRelationship.GeneratedByMe.ToString(c));
        Assert.AreEqual("Wife&Wealth", WuxingRelationship.OvercameByMe.ToString(c));
        Assert.AreEqual("Superior&Spirit", WuxingRelationship.OvercomingMe.ToString(c));
        Assert.AreEqual("Peer", WuxingRelationship.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelationship)100).ToString(c));
    }
}