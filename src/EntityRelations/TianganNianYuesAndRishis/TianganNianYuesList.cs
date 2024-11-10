using YiJingFramework.EntityRelations.GuaHexagramBagongs;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis;

/// <summary>
/// 年中各月。
/// Yues in a Nian.
/// </summary>
/// <param name="niangan">
/// 年。
/// Nian.
/// </param>
public sealed class TianganNianYuesList(Tiangan niangan) 
    : TianganNianYuesOrRiShisList<TianganNianYuesList>(GetFirst(niangan), Dizhi.Yin)
{
    private static Tiangan GetFirst(Tiangan niangan)
    {
        return (int)niangan switch
        {
            // 甲己之年丙作首
            0 or 5 => Tiangan.Bing,
            // 乙庚之岁戊为头
            1 or 6 => Tiangan.Wu,
            // 丙辛必定寻庚起
            2 or 7 => Tiangan.Geng,
            // 丁壬壬位顺行流
            3 or 8 => Tiangan.Ren,
            // 若问戊癸何方发 甲寅之上好追求
            _ => Tiangan.Jia,
        };
    }

}