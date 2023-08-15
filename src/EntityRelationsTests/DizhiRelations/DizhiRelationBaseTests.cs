using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.DizhiRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations.Tests;

[TestClass()]
public class DizhiRelationBaseTests
{
    [TestMethod()]
    public void SameAsTest()
    {
        var ziChong = new DizhiLiuchong(Dizhi.Zi);

        var chouChong = new DizhiLiuchong(Dizhi.Chou);
        Assert.IsFalse(ziChong.SameAs(chouChong));

        var wuChong = new DizhiLiuchong(Dizhi.Wu);
        Assert.IsTrue(ziChong.SameAs(wuChong));
    }
}