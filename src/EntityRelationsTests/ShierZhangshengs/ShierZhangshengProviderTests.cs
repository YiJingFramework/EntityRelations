using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs.Tests;

[TestClass()]
public class ShierZhangshengProviderTests
{
    [TestMethod()]
    public void ShierZhangshengProviderTest()
    {
        static IEnumerable<T> AddRepeatedly<T>(T starting, int step)
        {
            for (; ; )
            {
                yield return starting;
                starting = (dynamic?)starting + step;
            }
        }

        foreach (var zhangsheng in AddRepeatedly(Dizhi.Zi, 1).Take(12))
        {
            var provider = new ShierZhangshengProvider(zhangsheng, false);
            var cases = AddRepeatedly((ShierZhangsheng)(-36), 1).Zip(AddRepeatedly(zhangsheng, 1));
            foreach (var (z, d) in cases.Skip(36).Take(12))
                Assert.AreEqual(z, provider[d]);
            foreach (var (z, d) in cases.Take(200))
                Assert.AreEqual(d, provider[z]);
        }

        foreach (var zhangsheng in AddRepeatedly(Dizhi.Zi, 1).Take(12))
        {
            var provider = new ShierZhangshengProvider(zhangsheng, true);
            var cases = AddRepeatedly((ShierZhangsheng)(-36), 1).Zip(AddRepeatedly(zhangsheng, -1));
            foreach (var (z, d) in cases.Skip(36).Take(12))
                Assert.AreEqual(z, provider[d]);
            foreach (var (z, d) in cases.Take(200))
                Assert.AreEqual(d, provider[z]);
        }
    }
}