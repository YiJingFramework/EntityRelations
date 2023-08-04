using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;

/// <summary>
/// 关于天干地支五行的扩展。
/// Extensions about Wuxing attribute of Tiangans and Dizhis.
/// </summary>
public static class TianganDizhiWuxingExtensions
{
    /// <summary>
    /// 获取天干的五行。
    /// Get the Wuxing attribute of a Tiangan.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 五行。
    /// The Wuxing.
    /// </returns>
    public static Wuxing Wuxing(this Tiangan tiangan)
    {
        return (Wuxing)((tiangan.Index - 1) / 2);
    }

    /// <summary>
    /// 获取地支的五行。
    /// Get the Wuxing attribute of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 五行。
    /// The Wuxing.
    /// </returns>
    public static Wuxing Wuxing(this Dizhi dizhi)
    {
        return dizhi.Index switch
        {
            1 => PrimitiveTypes.Wuxing.Water, // 子
            2 => PrimitiveTypes.Wuxing.Earth, // 丑
            3 => PrimitiveTypes.Wuxing.Wood, // 寅
            4 => PrimitiveTypes.Wuxing.Wood, // 卯
            5 => PrimitiveTypes.Wuxing.Earth, // 辰
            6 => PrimitiveTypes.Wuxing.Fire, // 巳
            7 => PrimitiveTypes.Wuxing.Fire, // 午
            8 => PrimitiveTypes.Wuxing.Earth, // 未
            9 => PrimitiveTypes.Wuxing.Metal, // 申
            10 => PrimitiveTypes.Wuxing.Metal, // 酉
            11 => PrimitiveTypes.Wuxing.Earth, // 戌
            _ => PrimitiveTypes.Wuxing.Water, // 亥
        };
    }
}
