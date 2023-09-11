using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;

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
            1 => PrimitiveTypes.Wuxing.Shui, // 子
            2 => PrimitiveTypes.Wuxing.Tu, // 丑
            3 => PrimitiveTypes.Wuxing.Mu, // 寅
            4 => PrimitiveTypes.Wuxing.Mu, // 卯
            5 => PrimitiveTypes.Wuxing.Tu, // 辰
            6 => PrimitiveTypes.Wuxing.Huo, // 巳
            7 => PrimitiveTypes.Wuxing.Huo, // 午
            8 => PrimitiveTypes.Wuxing.Tu, // 未
            9 => PrimitiveTypes.Wuxing.Jin, // 申
            10 => PrimitiveTypes.Wuxing.Jin, // 酉
            11 => PrimitiveTypes.Wuxing.Tu, // 戌
            _ => PrimitiveTypes.Wuxing.Shui, // 亥
        };
    }

    /// <summary>
    /// 获取天干或地支的五行。
    /// Get the Wuxing attribute of a Tiangan or Dizhi.
    /// </summary>
    /// <param name="tianganOrDizhi">
    /// 天干或地支。
    /// The Tiangan or Dizhi.
    /// </param>
    /// <returns>
    /// 五行。
    /// The Wuxing.
    /// </returns>
    public static Wuxing Wuxing(this TianganOrDizhi tianganOrDizhi)
    {
        if (tianganOrDizhi.TryAsTiangan(out var tiangan, out var dizhi))
            return tiangan.Wuxing();
        return dizhi.Wuxing();
    }
}
