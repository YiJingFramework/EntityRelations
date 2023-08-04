using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.GuaCharacters.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.GuaCharacters.Extensions.Tests;

[TestClass()]
public class GuaToCharacterExtensionsTests
{
    [TestMethod()]
    public void ToUnicodeCharTest()
    {
        Assert.AreEqual('⚊', new GuaWith1Line(Yinyang.Yang).ToUnicodeChar());
        Assert.AreEqual('⚋', new GuaWith1Line(Yinyang.Yin).ToUnicodeChar());
        Assert.AreEqual('⚌', new GuaWith2Lines(Yinyang.Yang, Yinyang.Yang).ToUnicodeChar());
        Assert.AreEqual('⚍', new GuaWith2Lines(Yinyang.Yang, Yinyang.Yin).ToUnicodeChar());
        Assert.AreEqual('⚎', new GuaWith2Lines(Yinyang.Yin, Yinyang.Yang).ToUnicodeChar());
        Assert.AreEqual('⚏', new GuaWith2Lines(Yinyang.Yin, Yinyang.Yin).ToUnicodeChar());

        Assert.AreEqual('☴', GuaTrigram.Parse("011").ToUnicodeChar());
        Assert.AreEqual('☰', GuaTrigram.Parse("111").ToUnicodeChar());
        Assert.AreEqual('☷', GuaTrigram.Parse("000").ToUnicodeChar());
        Assert.AreEqual('☱', GuaTrigram.Parse("110").ToUnicodeChar());
        Assert.AreEqual('☵', GuaTrigram.Parse("010").ToUnicodeChar());

        Assert.AreEqual('䷀', GuaHexagram.Parse("111111").ToUnicodeChar());
        Assert.AreEqual('䷿', GuaHexagram.Parse("010101").ToUnicodeChar());
        Assert.AreEqual('䷭', GuaHexagram.Parse("011000").ToUnicodeChar());
    }
}