using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;

/// <summary>
/// 关于天干地支阴阳的扩展。
/// Extensions about Yinyang attribute of Tiangans and Dizhis.
/// </summary>
public static class TianganDizhiYinyangExtensions
{
    /// <summary>
    /// 获取天干的阴阳。
    /// Get the Yinyang attribute of a Tiangan.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// The Yinyang.
    /// </returns>
    public static Yinyang Yinyang(this Tiangan tiangan)
    {
        return new(tiangan.Index % 2 is 1);
    }

    /// <summary>
    /// 获取地支的阴阳。
    /// 是直接间隔着取阴阳，不是藏干等其他方法。
    /// Get the Yinyang attribute of a Dizhi.
    /// The result is produced by directly reducing the index modulo 2,
    /// rather than other methods like according to their stored Tiangans.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// The Yinyang.
    /// </returns>
    public static Yinyang Yinyang(this Dizhi dizhi)
    {
        return new(dizhi.Index % 2 is 1);
    }

    /// <summary>
    /// 获取天干或地支的阴阳。
    /// Get the Yinyang attribute of a Tiangan or Dizhi.
    /// </summary>
    /// <param name="tianganOrDizhi">
    /// 天干或地支。
    /// The Tiangan or Dizhi.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// The Yinyang.
    /// </returns>
    public static Yinyang Yinyang(this TianganOrDizhi tianganOrDizhi)
    {
        if (tianganOrDizhi.TryAsTiangan(out var tiangan, out var dizhi))
            return tiangan.Yinyang();
        return dizhi.Yinyang();
    }

    /// <summary>
    /// 获取干支的阴阳。
    /// Get the Yinyang attribute of a Ganzhi.
    /// </summary>
    /// <param name="ganzhi">
    /// 干支。
    /// The Ganzhi.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// The Yinyang.
    /// </returns>
    public static Yinyang Yinyang(this Ganzhi ganzhi)
    {
        return new(ganzhi.Index % 2 is 1);
    }
}
