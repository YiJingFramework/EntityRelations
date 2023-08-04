using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaDerivingExtensions.Tests;

[TestClass()]
public class GuaDerivingExtensionsTests
{
    [TestMethod()]
    public void ReverseLinesTest()
    {
        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("000").ReverseLines());
        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("111").ReverseLines(0, 1, 2));
        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("101").ReverseLines(0, 2, 1, 1, 1, 1));
        _ = Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => Gua.Parse("101").ReverseLines(0, 2, 3, -234, 1239109));

        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("101").ReverseLines(
            new[] { 0, 2, 3, -234, 1239109 }, false));
        _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => Gua.Parse("101").ReverseLines(
            new[] { 0, 2, 3, -234, 1239109 }));

        Assert.AreEqual(Gua.Parse(""), Gua.Parse("").ReverseLines(new[] { 1, 2, 3 }, false));


        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("000").ReverseLines());
        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("111").ReverseLines(0, 1, 2));
        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("101").ReverseLines(0, 2, 1, 1, 1, 1));
        _ = Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => GuaTrigram.Parse("101").ReverseLines(0, 2, 3, -234, 1239109));

        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("101").ReverseLines(
            new[] { 0, 2, 3, -234, 1239109 }, false));
        _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => GuaTrigram.Parse("101").ReverseLines(
            new[] { 0, 2, 3, -234, 1239109 }));
        _ = Assert.ThrowsException<ArgumentNullException>(() => ((GuaTrigram?)null)!.ReverseLines());
    }

    [TestMethod()]
    public void CuoguaTest()
    {
        Assert.AreEqual(Gua.Parse("111010011"), Gua.Parse("000101100").Cuogua());
        Assert.AreEqual(Gua.Parse(""), Gua.Parse("").Cuogua());
        Assert.AreEqual(GuaHexagram.Parse("110011"), GuaHexagram.Parse("001100").Cuogua());
    }

    [TestMethod()]
    public void ZongguaTest()
    {
        Assert.AreEqual(new Gua(Gua.Parse("000101100").Reverse()), Gua.Parse("000101100").Zonggua());
        Assert.AreEqual(Gua.Parse(""), Gua.Parse("").Zonggua());
        Assert.AreEqual(new GuaHexagram(Gua.Parse("001100").Reverse()),
            GuaHexagram.Parse("001100").Zonggua());
    }

    [TestMethod()]
    public void HuguaTest()
    {
        Assert.AreEqual(GuaHexagram.Parse("011111"), GuaHexagram.Parse("101111").Hugua());
        Assert.AreEqual(GuaHexagram.Parse("010101"), GuaHexagram.Parse("101011").Hugua());
        Assert.AreEqual(GuaHexagram.Parse("111111"), GuaHexagram.Parse("111111").Hugua());
        Assert.AreEqual(GuaHexagram.Parse("000000"), GuaHexagram.Parse("000000").Hugua());
    }

    [TestMethod()]
    public void JiaoguaTest()
    {
        Assert.AreEqual(GuaHexagram.Parse("111101"), GuaHexagram.Parse("101111").Jiaogua());
        Assert.AreEqual(GuaHexagram.Parse("011101"), GuaHexagram.Parse("101011").Jiaogua());
        Assert.AreEqual(GuaHexagram.Parse("111111"), GuaHexagram.Parse("111111").Jiaogua());
        Assert.AreEqual(GuaHexagram.Parse("000000"), GuaHexagram.Parse("000000").Jiaogua());
    }

    [TestMethod()]
    public void SplitTest()
    {
        Assert.AreEqual(2, Gua.Parse("101111").Split(3).Count());
        Assert.AreEqual(Gua.Parse("101"), Gua.Parse("101111").Split(3).ElementAt(0));
        Assert.AreEqual(Gua.Parse("111"), Gua.Parse("101111").Split(3).ElementAt(1));

        Assert.AreEqual(2, Gua.Parse("101111").Split(3).Count());
        Assert.AreEqual(null, Gua.Parse("").Split(3).FirstOrDefault());

        Assert.AreEqual(2, GuaHexagram.Parse("101111").Split(3).Count());
        Assert.AreEqual(Gua.Parse("101"), GuaHexagram.Parse("101111").Split(3).ElementAt(0));
        Assert.AreEqual(Gua.Parse("111"), GuaHexagram.Parse("101111").Split(3).ElementAt(1));
    }
}