using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.EntityStrings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.EntityRelations.WuxingRelations;

namespace YiJingFramework.EntityRelations.EntityStrings.Conversions.Tests;

[TestClass()]
public class EntityToStringExtensionsTests
{
    [TestMethod()]
    public void ToStringTest()
    {
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