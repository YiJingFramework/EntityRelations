﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs.Extensions.Tests;

[TestClass()]
public class WuxingShierZhangshengExtensionsTests
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

        AssertSameProvider(new(Dizhi.Hai, false), Wuxing.Mu.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Yin, false), Wuxing.Huo.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Si, false), Wuxing.Jin.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Shen, false), Wuxing.Shui.ShierZhangsheng());

        AssertSameProvider(new(Dizhi.Shen, false), Wuxing.Tu.ShierZhangsheng());
        AssertSameProvider(new(Dizhi.Shen, false), Wuxing.Tu.ShierZhangsheng(true));
        AssertSameProvider(new(Dizhi.Yin, false), Wuxing.Tu.ShierZhangsheng(false));

        foreach (var t in AddRepeatedly(Wuxing.Mu, 1).Take(5))
        {
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
            {
                var provider = t.ShierZhangsheng(true);
                foreach (var d in AddRepeatedly(Dizhi.Zi, 1).Take(12))
                {
                    Assert.AreEqual(provider[d], t.ShierZhangsheng(d, true));
                }
                foreach (var s in AddRepeatedly((ShierZhangsheng)(-36), 1).Take(120))
                {
                    Assert.AreEqual(provider[s], t.ShierZhangsheng(s, true));
                }
            }
            {
                var provider = t.ShierZhangsheng(false);
                foreach (var d in AddRepeatedly(Dizhi.Zi, 1).Take(12))
                {
                    Assert.AreEqual(provider[d], t.ShierZhangsheng(d, false));
                }
                foreach (var s in AddRepeatedly((ShierZhangsheng)(-36), 1).Take(120))
                {
                    Assert.AreEqual(provider[s], t.ShierZhangsheng(s, false));
                }
            }
        }
    }
}