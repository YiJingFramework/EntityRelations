using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.GuaCharacters.Extensions;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelations.GuaCharacters.Tests;

[TestClass()]
public class GuaFromCharacterTests
{
    [TestMethod()]
    public void TryConvertTest()
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
            {
                var cdd = gua.AsFixed<GuaWith1Line>().ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out GuaWith1Line? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd?.AsGua());
            }
            {
                var cdd = gua.ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out Gua? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd);
            }
        }

        for (int i = 0; i < 100; i++)
        {
            var gua = GetRandomGua(2);
            {
                var cdd = gua.AsFixed<GuaWith2Lines>().ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out GuaWith2Lines? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd?.AsGua());
            }
            {
                var cdd = gua.ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out Gua? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd);
            }
        }

        for (int i = 0; i < 100; i++)
        {
            var gua = GetRandomGua(3);
            {
                var cdd = gua.AsFixed<GuaTrigram>().ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out GuaTrigram? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd?.AsGua());
            }
            {
                var cdd = gua.ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out Gua? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd);
            }
        }

        for (int i = 0; i < 100; i++)
        {
            var gua = GetRandomGua(6);
            {
                var cdd = gua.AsFixed<GuaHexagram>().ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out GuaHexagram? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd?.AsGua());
            }
            {
                var cdd = gua.ToUnicodeChar();
                var bl = GuaFromCharacter.TryConvert(cdd, out Gua? cddd);
                Assert.IsTrue(bl);
                Assert.AreEqual(gua, cddd);
            }
        }
    }
}