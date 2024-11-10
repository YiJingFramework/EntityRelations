using System.Collections;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis;

/// <summary>
/// 日中各时。
/// Shis in a Ri.
/// </summary>
/// <param name="rigan">
/// 日。
/// Ri.
/// </param>
public sealed class TianganRiShisList(Tiangan rigan) : TianganNianYuesOrRiShisList<TianganRiShisList>(GetFirst(rigan))
{
    private static Tiangan GetFirst(Tiangan rigan)
    {
        return (int)rigan switch
        {
            // 甲己还加甲
            0 or 5 => Tiangan.Jia,
            // 乙庚丙作初
            1 or 6 => Tiangan.Bing,
            // 丙辛从戊起
            2 or 7 => Tiangan.Wu,
            // 丁壬庚子居
            3 or 8 => Tiangan.Geng,
            // 戊癸起壬子 周而复始求
            _ => Tiangan.Ren,
        };
    }
}
