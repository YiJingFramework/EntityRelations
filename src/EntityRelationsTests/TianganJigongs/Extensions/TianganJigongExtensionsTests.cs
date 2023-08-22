using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.TianganJigongs.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.EntityRelations.ShierZhangshengs.Extensions;
using YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;
using YiJingFramework.EntityRelations.ShierZhangshengs;

namespace YiJingFramework.EntityRelations.TianganJigongs.Extensions.Tests;

[TestClass()]
public class TianganJigongExtensionsTests
{
    [TestMethod()]
    public void JigongTest()
    {
        for (int i = 1; i <= 10; i++)
        {
            var tiangan = new Tiangan(i);
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