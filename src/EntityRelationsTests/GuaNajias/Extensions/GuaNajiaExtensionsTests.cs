using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaNajias.Extensions.Tests;

[TestClass()]
public class GuaNajiaExtensionsTests
{
    private static void AssertNajia(
        Ganzhi expected0, Ganzhi expected1, Ganzhi expected2,
        Ganzhi expected3, Ganzhi expected4, Ganzhi expected5,
        IReadOnlyList<Ganzhi> actual)
    {
        Assert.AreEqual(6, actual.Count);
        Assert.AreEqual(expected0, actual[0]);
        Assert.AreEqual(expected1, actual[1]);
        Assert.AreEqual(expected2, actual[2]);
        Assert.AreEqual(expected3, actual[3]);
        Assert.AreEqual(expected4, actual[4]);
        Assert.AreEqual(expected5, actual[5]);
    }

    [TestMethod()]
    public void NajiaBachunTest()
    {
        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Jia, Dizhi.Zi),
            Ganzhi.FromGanzhi(Tiangan.Jia, Dizhi.Yin),
            Ganzhi.FromGanzhi(Tiangan.Jia, Dizhi.Chen),
            Ganzhi.FromGanzhi(Tiangan.Ren, Dizhi.Wu),
            Ganzhi.FromGanzhi(Tiangan.Ren, Dizhi.Shen),
            Ganzhi.FromGanzhi(Tiangan.Ren, Dizhi.Xu),
            GuaHexagram.Parse("111111").Najia());

        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Wu, Dizhi.Yin),
            Ganzhi.FromGanzhi(Tiangan.Wu, Dizhi.Chen),
            Ganzhi.FromGanzhi(Tiangan.Wu, Dizhi.Wu),
            Ganzhi.FromGanzhi(Tiangan.Wu, Dizhi.Shen),
            Ganzhi.FromGanzhi(Tiangan.Wu, Dizhi.Xu),
            Ganzhi.FromGanzhi(Tiangan.Wu, Dizhi.Zi),
            GuaHexagram.Parse("010010").Najia());

        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Geng, Dizhi.Zi),
            Ganzhi.FromGanzhi(Tiangan.Geng, Dizhi.Yin),
            Ganzhi.FromGanzhi(Tiangan.Geng, Dizhi.Chen),
            Ganzhi.FromGanzhi(Tiangan.Geng, Dizhi.Wu),
            Ganzhi.FromGanzhi(Tiangan.Geng, Dizhi.Shen),
            Ganzhi.FromGanzhi(Tiangan.Geng, Dizhi.Xu),
            GuaHexagram.Parse("100100").Najia());

        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Bing, Dizhi.Chen),
            Ganzhi.FromGanzhi(Tiangan.Bing, Dizhi.Wu),
            Ganzhi.FromGanzhi(Tiangan.Bing, Dizhi.Shen),
            Ganzhi.FromGanzhi(Tiangan.Bing, Dizhi.Xu),
            Ganzhi.FromGanzhi(Tiangan.Bing, Dizhi.Zi),
            Ganzhi.FromGanzhi(Tiangan.Bing, Dizhi.Yin),
            GuaHexagram.Parse("001001").Najia());

        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Yi, Dizhi.Wei),
            Ganzhi.FromGanzhi(Tiangan.Yi, Dizhi.Si),
            Ganzhi.FromGanzhi(Tiangan.Yi, Dizhi.Mao),
            Ganzhi.FromGanzhi(Tiangan.Gui, Dizhi.Chou),
            Ganzhi.FromGanzhi(Tiangan.Gui, Dizhi.Hai),
            Ganzhi.FromGanzhi(Tiangan.Gui, Dizhi.You),
            GuaHexagram.Parse("000000").Najia());

        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Xin, Dizhi.Chou),
            Ganzhi.FromGanzhi(Tiangan.Xin, Dizhi.Hai),
            Ganzhi.FromGanzhi(Tiangan.Xin, Dizhi.You),
            Ganzhi.FromGanzhi(Tiangan.Xin, Dizhi.Wei),
            Ganzhi.FromGanzhi(Tiangan.Xin, Dizhi.Si),
            Ganzhi.FromGanzhi(Tiangan.Xin, Dizhi.Mao),
            GuaHexagram.Parse("011011").Najia());

        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Ji, Dizhi.Mao),
            Ganzhi.FromGanzhi(Tiangan.Ji, Dizhi.Chou),
            Ganzhi.FromGanzhi(Tiangan.Ji, Dizhi.Hai),
            Ganzhi.FromGanzhi(Tiangan.Ji, Dizhi.You),
            Ganzhi.FromGanzhi(Tiangan.Ji, Dizhi.Wei),
            Ganzhi.FromGanzhi(Tiangan.Ji, Dizhi.Si),
            GuaHexagram.Parse("101101").Najia());

        AssertNajia(
            Ganzhi.FromGanzhi(Tiangan.Ding, Dizhi.Si),
            Ganzhi.FromGanzhi(Tiangan.Ding, Dizhi.Mao),
            Ganzhi.FromGanzhi(Tiangan.Ding, Dizhi.Chou),
            Ganzhi.FromGanzhi(Tiangan.Ding, Dizhi.Hai),
            Ganzhi.FromGanzhi(Tiangan.Ding, Dizhi.You),
            Ganzhi.FromGanzhi(Tiangan.Ding, Dizhi.Wei),
            GuaHexagram.Parse("110110").Najia());
    }

    [TestMethod()]
    public void NajiaOthersTest()
    {
        for (int lowerValue = 0; lowerValue < 8; lowerValue++)
        {
            var lowerString = Convert.ToString(lowerValue, 2).PadLeft(3, '0');
            for (int upperValue = 0; upperValue < 8; upperValue++)
            {
                var upperString = Convert.ToString(lowerValue, 2).PadLeft(3, '0');

                var bachunLower = GuaHexagram.Parse($"{lowerString}{lowerString}");
                var bachunUpper = GuaHexagram.Parse($"{upperString}{upperString}");
                var gua = GuaHexagram.Parse($"{lowerString}{upperString}");

                var lowerNajia = bachunLower.Najia();
                var upperNajia = bachunUpper.Najia();
                var guaNajia = gua.Najia();

                Assert.AreEqual(6, guaNajia.Count);
                Assert.AreEqual(lowerNajia[0], guaNajia[0]);
                Assert.AreEqual(lowerNajia[1], guaNajia[1]);
                Assert.AreEqual(lowerNajia[2], guaNajia[2]);
                Assert.AreEqual(upperNajia[3], guaNajia[3]);
                Assert.AreEqual(upperNajia[4], guaNajia[4]);
                Assert.AreEqual(upperNajia[5], guaNajia[5]);
            }
        }
    }
}