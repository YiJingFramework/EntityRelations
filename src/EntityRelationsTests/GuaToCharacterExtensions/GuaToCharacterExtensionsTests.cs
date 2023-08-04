using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelations.GuaToCharacterExtensions.Tests;

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

    [TestMethod()]
    public void TryFromUnicodeCharTest()
    {
        static Gua GetRandomGua(int lineCount)
        {
            List<Yinyang> lines = new List<Yinyang>(lineCount);
            for (int i = 0; i < lineCount; i++)
            {
                lines.Add(Random.Shared.Next(0, 2) == 0 ? Yinyang.Yang : Yinyang.Yin);
            }
            return new Gua(lines);
        }

        for (int i = 0; i < 100; i++)
        {
            var gua = GetRandomGua(1);
            var cdd = gua.As<GuaWith1Line>().ToUnicodeChar();
            var bl = GuaToCharacterExtensions.TryFromUnicodeChar(cdd, out var cddd);
            Assert.IsTrue(bl);
            Assert.AreEqual(gua, cddd);
        }

        for (int i = 0; i < 100; i++)
        {
            var gua = GetRandomGua(2);
            var cdd = gua.As<GuaWith2Lines>().ToUnicodeChar();
            var bl = GuaToCharacterExtensions.TryFromUnicodeChar(cdd, out var cddd);
            Assert.IsTrue(bl);
            Assert.AreEqual(gua, cddd);
        }
        for (int i = 0; i < 100; i++)
        {
            var gua = GetRandomGua(3);
            var cdd = gua.As<GuaTrigram>().ToUnicodeChar();
            var bl = GuaToCharacterExtensions.TryFromUnicodeChar(cdd, out var cddd);
            Assert.IsTrue(bl);
            Assert.AreEqual(gua, cddd);
        }
        for (int i = 0; i < 100; i++)
        {
            var gua = GetRandomGua(6);
            var cdd = gua.As<GuaHexagram>().ToUnicodeChar();
            var bl = GuaToCharacterExtensions.TryFromUnicodeChar(cdd, out var cddd);
            Assert.IsTrue(bl);
            Assert.AreEqual(gua, cddd);
        }
    }
}