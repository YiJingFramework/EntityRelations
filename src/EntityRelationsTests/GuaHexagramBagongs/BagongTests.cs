using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.GuaDerivations.Extensions;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaHexagramBagongs.Tests;

[TestClass()]
public class BagongTests
{
    [TestMethod()]
    public void FunctionTest()
    {
        var bagong = new Bagong(GuaTrigram.Parse("111"));
        Assert.AreEqual(GuaHexagram.Parse("111111"), bagong[Shiying.Bachun]);
        Assert.AreEqual(GuaHexagram.Parse("011111"), bagong[Shiying.Yishi]);
        Assert.AreEqual(GuaHexagram.Parse("001111"), bagong[Shiying.Ershi]);
        Assert.AreEqual(GuaHexagram.Parse("000111"), bagong[Shiying.Sanshi]);
        Assert.AreEqual(GuaHexagram.Parse("000011"), bagong[Shiying.Sishi]);
        Assert.AreEqual(GuaHexagram.Parse("000001"), bagong[Shiying.Wushi]);
        Assert.AreEqual(GuaHexagram.Parse("000101"), bagong[Shiying.Youhun]);
        Assert.AreEqual(GuaHexagram.Parse("111101"), bagong[Shiying.Guihun]);

        bagong = new Bagong(GuaTrigram.Parse("000"));
        Assert.AreEqual(GuaHexagram.Parse("000000"), bagong[Shiying.Bachun]);
        Assert.AreEqual(GuaHexagram.Parse("100000"), bagong[Shiying.Yishi]);
        Assert.AreEqual(GuaHexagram.Parse("110000"), bagong[Shiying.Ershi]);
        Assert.AreEqual(GuaHexagram.Parse("111000"), bagong[Shiying.Sanshi]);
        Assert.AreEqual(GuaHexagram.Parse("111100"), bagong[Shiying.Sishi]);
        Assert.AreEqual(GuaHexagram.Parse("111110"), bagong[Shiying.Wushi]);
        Assert.AreEqual(GuaHexagram.Parse("111010"), bagong[Shiying.Youhun]);
        Assert.AreEqual(GuaHexagram.Parse("000010"), bagong[Shiying.Guihun]);

        for (int i = 0; i < 8; i++)
        {
            var guaString = Convert.ToString(i, 2).PadLeft(3, '0');
            bagong = new Bagong(GuaTrigram.Parse(guaString));
            Assert.AreEqual(GuaTrigram.Parse(guaString), bagong.Gong);

            var gua = bagong[Shiying.Bachun];
            Assert.AreEqual(GuaHexagram.Parse(guaString + guaString), gua);
            gua = gua.ChangeYaos(0);
            Assert.AreEqual(gua, bagong[Shiying.Yishi]);
            gua = gua.ChangeYaos(1);
            Assert.AreEqual(gua, bagong[Shiying.Ershi]);
            gua = gua.ChangeYaos(2);
            Assert.AreEqual(gua, bagong[Shiying.Sanshi]);
            gua = gua.ChangeYaos(3);
            Assert.AreEqual(gua, bagong[Shiying.Sishi]);
            gua = gua.ChangeYaos(4);
            Assert.AreEqual(gua, bagong[Shiying.Wushi]);
            gua = gua.ChangeYaos(3);
            Assert.AreEqual(gua, bagong[Shiying.Youhun]);
            gua = gua.ChangeYaos(0, 1, 2);
            Assert.AreEqual(gua, bagong[Shiying.Guihun]);
        }
    }

    [TestMethod()]
    public void ComparisonTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            var r1 = Random.Shared.Next(0, 8);
            var g1 = GuaTrigram.Parse(Convert.ToString(r1, 2).PadLeft(3, '0'));
            var gg1 = new Bagong(g1);
            var r2 = Random.Shared.Next(0, 8);
            var g2 = GuaTrigram.Parse(Convert.ToString(r2, 2).PadLeft(3, '0'));
            var gg2 = new Bagong(g2);

            Assert.AreEqual(g1.CompareTo(g2), gg1.CompareTo(gg2));
            Assert.AreEqual(g1.Equals(g2), gg1.Equals(gg2));
        }
    }
}