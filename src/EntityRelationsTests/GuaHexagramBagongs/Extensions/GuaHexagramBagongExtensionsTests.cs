using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaHexagramBagongs.Extensions.Tests;

[TestClass()]
public class GuaHexagramBagongExtensionsTests
{
    [TestMethod()]
    public void BagongTest()
    {
        for (int i = 0; i < 8; i++)
        {
            var trigram = GuaTrigram.Parse(Convert.ToString(i, 2).PadLeft(3, '0'));
            var bagong = new Bagong(trigram);

            foreach (var shiying in Enum.GetValues<Shiying>())
            {
                var gua = bagong[shiying];
                Assert.AreEqual((bagong, shiying), gua.Bagong());
            }
        }
    }
}