using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs.Extensions.Tests;

[TestClass()]
public class TianganShierZhangshengExtensionsTests
{
    [TestMethod()]
    public void ShierZhangshengTest()
    {
        static IEnumerable<T> AddRepeatedly<T>(T starting, int step)
        {
            for (; ; )
            {
                yield return starting;
                starting = (dynamic?)starting + step;
            }
        }

        static void AssertSameProvider(
            ShierZhangshengProvider provider1, ShierZhangshengProvider provider2)
        {
            foreach (var d in AddRepeatedly(Dizhi.Zi, 1).Take(12))
                Assert.AreEqual(provider1[d], provider2[d]);
        }

        AssertSameProvider(new(Dizhi.Hai, false), Tiangan.Jia.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Yin, false), Tiangan.Bing.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Yin, false), Tiangan.Wu.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Si, false), Tiangan.Geng.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Shen, false), Tiangan.Ren.ShierZhangsheng());

        AssertSameProvider(new(Dizhi.Mao, true), Tiangan.Gui.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Wu, true), Tiangan.Yi.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.You, true), Tiangan.Ding.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.You, true), Tiangan.Ji.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Zi, true), Tiangan.Xin.ShierZhangsheng());

        foreach (var t in AddRepeatedly(Tiangan.Jia, 1).Take(10))
        {
            var provider = t.ShierZhangsheng();
            foreach (var d in AddRepeatedly(Dizhi.Zi, 1).Take(12))
            {
                Assert.AreEqual(provider[d], t.ShierZhangsheng(d));
            }
            foreach (var s in AddRepeatedly((ShierZhangsheng)(-36), 1).Take(120))
            {
                Assert.AreEqual(provider[s], t.ShierZhangsheng(s));
            }
        }
    }
}