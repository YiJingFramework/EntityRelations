using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.EntityStrings.Extensions;
using YiJingFramework.EntityRelations.WuxingRelations;

namespace YiJingFramework.EntityRelations.EntityStrings.Conversions.Tests;

[TestClass()]
public class EntityToStringExtensionsTests
{
    [TestMethod()]
    public void ToStringTest()
    {
        var c = WuxingRelationToStringConversions.InChinese;
        Assert.AreEqual("生我", WuxingRelation.ShengsMe.ToString(c));
        Assert.AreEqual("我生", WuxingRelation.IsShengedByMe.ToString(c));
        Assert.AreEqual("我克", WuxingRelation.IsKeedByMe.ToString(c));
        Assert.AreEqual("克我", WuxingRelation.KesMe.ToString(c));
        Assert.AreEqual("同我", WuxingRelation.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelation)100).ToString(c));

        c = WuxingRelationToStringConversions.Liuqin;
        Assert.AreEqual("父母", WuxingRelation.ShengsMe.ToString(c));
        Assert.AreEqual("子孙", WuxingRelation.IsShengedByMe.ToString(c));
        Assert.AreEqual("妻财", WuxingRelation.IsKeedByMe.ToString(c));
        Assert.AreEqual("官鬼", WuxingRelation.KesMe.ToString(c));
        Assert.AreEqual("兄弟", WuxingRelation.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelation)100).ToString(c));

        c = WuxingRelationToStringConversions.LiuqinInEnglish;
        Assert.AreEqual("Parent", WuxingRelation.ShengsMe.ToString(c));
        Assert.AreEqual("Offspring", WuxingRelation.IsShengedByMe.ToString(c));
        Assert.AreEqual("Wife&Wealth", WuxingRelation.IsKeedByMe.ToString(c));
        Assert.AreEqual("Superior&Spirit", WuxingRelation.KesMe.ToString(c));
        Assert.AreEqual("Peer", WuxingRelation.SameAsMe.ToString(c));
        Assert.AreEqual("100", ((WuxingRelation)100).ToString(c));
    }
}