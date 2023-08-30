using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelations.DizhiRelations.Extensions;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiMengZhongJis.Extensions.Tests;

[TestClass()]
public class DizhiMengZhongJiExtensionsTests
{
    [TestMethod()]
    public void MengZhongJiTest()
    {
        for (int i = 1; i <= 12; i++)
        {
            var dizhi = (Dizhi)(i);
            switch (dizhi.MengZhongJi())
            {
                case MengZhongJi.Meng:
                    Assert.AreEqual(dizhi, dizhi.SanhuiRelation().DizhiOfMeng);
                    break;
                case MengZhongJi.Zhong:
                    Assert.AreEqual(dizhi, dizhi.SanhuiRelation().DizhiOfZhong);
                    break;
                case MengZhongJi.Ji:
                    Assert.AreEqual(dizhi, dizhi.SanhuiRelation().DizhiOfJi);
                    break;
                default:
                    Assert.Fail();
                    break;
            }
        }
    }
}