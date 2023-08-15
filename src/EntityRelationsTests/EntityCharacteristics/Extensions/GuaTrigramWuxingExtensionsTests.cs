using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions.Tests;

[TestClass()]
public class GuaTrigramWuxingExtensionsTests
{
    private static IEnumerable<GuaTrigram> QianDuiLiZhenXunKanGenKun()
    {
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yang, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yang, Yinyang.Yin);
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yin, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yin, Yinyang.Yin);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yang, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yang, Yinyang.Yin);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yin, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yin, Yinyang.Yin);
    }

    [TestMethod()]
    public void WuxingTest()
    {
        var wuxings = QianDuiLiZhenXunKanGenKun().Select((g) => g.Wuxing());
        Assert.IsTrue(wuxings.SequenceEqual(new[] {
            Wuxing.Metal,
            Wuxing.Metal,
            Wuxing.Fire,
            Wuxing.Wood,
            Wuxing.Wood,
            Wuxing.Water,
            Wuxing.Earth,
            Wuxing.Earth
        }));
    }
}