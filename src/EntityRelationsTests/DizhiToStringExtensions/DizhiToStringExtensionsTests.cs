using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.DizhiToStringExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using System.Xml.Linq;
using YiJingFramework.EntityRelations.WuxingRelationshipExtensions;
using YiJingFramework.EntityRelations.Shared;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace YiJingFramework.EntityRelations.DizhiToStringExtensions.Tests;

[TestClass()]
public class DizhiToStringExtensionsTests
{
    [TestMethod()]
    public void ToStringTest()
    {
        ConversionToString<Dizhi>? conversion = null;
        Assert.AreEqual("Zi", Dizhi.Zi.ToString(conversion));
        Assert.AreEqual("Chou", Dizhi.Chou.ToString(conversion));
        
        conversion = DizhiToStringConversions.Shengxiao;
        Assert.AreEqual("鼠", Dizhi.Zi.ToString(conversion));
        Assert.AreEqual("牛", Dizhi.Chou.ToString(conversion));
        Assert.AreEqual("虎", Dizhi.Yin.ToString(conversion));
        Assert.AreEqual("兔", Dizhi.Mao.ToString(conversion));
        Assert.AreEqual("龙", Dizhi.Chen.ToString(conversion));
        Assert.AreEqual("蛇", Dizhi.Si.ToString(conversion));
        Assert.AreEqual("马", Dizhi.Wu.ToString(conversion));
        Assert.AreEqual("羊", Dizhi.Wei.ToString(conversion));
        Assert.AreEqual("猴", Dizhi.Shen.ToString(conversion));
        Assert.AreEqual("鸡", Dizhi.You.ToString(conversion));
        Assert.AreEqual("狗", Dizhi.Xu.ToString(conversion));
        Assert.AreEqual("猪", Dizhi.Hai.ToString(conversion));

        conversion = DizhiToStringConversions.ShengxiaoInEnglish;
        Assert.AreEqual("Rat", ((Dizhi)1).ToString(conversion));
        Assert.AreEqual("Cow", ((Dizhi)2).ToString(conversion));
        Assert.AreEqual("Tiger", ((Dizhi)3).ToString(conversion));
        Assert.AreEqual("Rabbit", ((Dizhi)4).ToString(conversion));
        Assert.AreEqual("Long", ((Dizhi)5).ToString(conversion));
        Assert.AreEqual("Snake", ((Dizhi)6).ToString(conversion));
        Assert.AreEqual("Horse", ((Dizhi)7).ToString(conversion));
        Assert.AreEqual("Sheep", ((Dizhi)8).ToString(conversion));
        Assert.AreEqual("Monkey", ((Dizhi)9).ToString(conversion));
        Assert.AreEqual("Chicken", ((Dizhi)10).ToString(conversion));
        Assert.AreEqual("Dog", ((Dizhi)11).ToString(conversion));
        Assert.AreEqual("Pig", ((Dizhi)12).ToString(conversion));
    }
}