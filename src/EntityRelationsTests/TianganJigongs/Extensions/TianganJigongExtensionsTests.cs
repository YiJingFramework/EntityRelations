using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;
using YiJingFramework.EntityRelations.ShierZhangshengs;
using YiJingFramework.EntityRelations.ShierZhangshengs.Extensions;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganJigongs.Extensions.Tests;

[TestClass()]
public class TianganJigongExtensionsTests
{
    [TestMethod()]
    public void JigongTest()
    {
        for (int i = 1; i <= 10; i++)
        {
            var tiangan = Tiangan.FromIndex(i);
            if (tiangan.Yinyang().IsYang)
            {
                Assert.AreEqual(tiangan.ShierZhangsheng(ShierZhangsheng.Linguan), tiangan.Jigong());
            }
            else
            {
                Assert.AreEqual(tiangan.ShierZhangsheng(ShierZhangsheng.Guandai), tiangan.Jigong());
            }
        }
    }
}