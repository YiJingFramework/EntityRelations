using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.EntityToString.Conversions;
using YiJingFramework.EntityRelations.Shared;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelationshipExtensions.Tests;

[TestClass()]
public class WuxingRelationshipExtensionsTests
{
    [TestMethod()]
    public void GetWuxingRelationshipTest()
    {
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Wood.GetWuxingRelationship(Wuxing.Fire));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Fire.GetWuxingRelationship(Wuxing.Earth));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Earth.GetWuxingRelationship(Wuxing.Metal));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Metal.GetWuxingRelationship(Wuxing.Water));
        Assert.AreEqual(WuxingRelation.GeneratedByMe,
            Wuxing.Water.GetWuxingRelationship(Wuxing.Wood));

        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Wood.GetWuxingRelationship(Wuxing.Water));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Water.GetWuxingRelationship(Wuxing.Metal));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Metal.GetWuxingRelationship(Wuxing.Earth));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Earth.GetWuxingRelationship(Wuxing.Fire));
        Assert.AreEqual(WuxingRelation.GeneratingMe,
            Wuxing.Fire.GetWuxingRelationship(Wuxing.Wood));
    }

    [TestMethod()]
    public void GetWuxingThatTest()
    {
        for (int i = 0; i < 5; i++)
        {
            var woodP = (Wuxing)i;
            var fireP = woodP.GetWuxingThat(WuxingRelation.GeneratedByMe);
            var earthP = fireP.GetWuxingThat(WuxingRelation.GeneratedByMe);
            var metalP = earthP.GetWuxingThat(WuxingRelation.GeneratedByMe);
            var waterP = metalP.GetWuxingThat(WuxingRelation.GeneratedByMe);

            Assert.AreEqual(WuxingRelation.GeneratedByMe,
                woodP.GetWuxingRelationship(fireP));
            Assert.AreEqual(WuxingRelation.OvercameByMe,
                woodP.GetWuxingRelationship(earthP));
            Assert.AreEqual(WuxingRelation.OvercomingMe,
                woodP.GetWuxingRelationship(metalP));
            Assert.AreEqual(WuxingRelation.GeneratingMe,
                woodP.GetWuxingRelationship(waterP));

            Assert.AreEqual(fireP,
                woodP.GetWuxingThat(WuxingRelation.GeneratedByMe));
            Assert.AreEqual(earthP,
                woodP.GetWuxingThat(WuxingRelation.OvercameByMe));
            Assert.AreEqual(metalP,
                woodP.GetWuxingThat(WuxingRelation.OvercomingMe));
            Assert.AreEqual(waterP,
                woodP.GetWuxingThat(WuxingRelation.GeneratingMe));
        }
    }


    [TestMethod()]
    public void ToStringTest()
    {
        Assert.AreEqual(
            WuxingRelation.GeneratingMe.ToString(), 
            WuxingRelation.GeneratingMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelation.GeneratedByMe.ToString(),
            WuxingRelation.GeneratedByMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelation.OvercameByMe.ToString(),
            WuxingRelation.OvercameByMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelation.OvercomingMe.ToString(),
            WuxingRelation.OvercomingMe.ToString(conversion: null));
        Assert.AreEqual(
            WuxingRelation.SameAsMe.ToString(),
            WuxingRelation.SameAsMe.ToString(conversion: null));
        Assert.AreEqual(
            ((WuxingRelation)100).ToString(),
            ((WuxingRelation)100).ToString(conversion: null));

        var c = WuxingRelationToStringConversions.InChinese;
        Assert.AreEqual("生我", WuxingRelation.GeneratingMe.ToString(c));
        Assert.AreEqual("我生", WuxingRelation.GeneratedByMe.ToString(c));
        Assert.AreEqual("我克", WuxingRelation.OvercameByMe.ToString(c));
        Assert.AreEqual("克我", WuxingRelation.OvercomingMe.ToString(c));
        Assert.AreEqual("同我", WuxingRelation.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelation)100).ToString(c));

        c = WuxingRelationToStringConversions.Liuqin;
        Assert.AreEqual("父母", WuxingRelation.GeneratingMe.ToString(c));
        Assert.AreEqual("子孙", WuxingRelation.GeneratedByMe.ToString(c));
        Assert.AreEqual("妻财", WuxingRelation.OvercameByMe.ToString(c));
        Assert.AreEqual("官鬼", WuxingRelation.OvercomingMe.ToString(c));
        Assert.AreEqual("兄弟", WuxingRelation.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelation)100).ToString(c));

        c = WuxingRelationToStringConversions.LiuqinInEnglish;
        Assert.AreEqual("Parent", WuxingRelation.GeneratingMe.ToString(c));
        Assert.AreEqual("Offspring", WuxingRelation.GeneratedByMe.ToString(c));
        Assert.AreEqual("Wife&Wealth", WuxingRelation.OvercameByMe.ToString(c));
        Assert.AreEqual("Superior&Spirit", WuxingRelation.OvercomingMe.ToString(c));
        Assert.AreEqual("Peer", WuxingRelation.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelation)100).ToString(c));
    }
}