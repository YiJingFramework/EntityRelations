using YiJingFramework.PrimitiveTypes;

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
        return new((int)tiangan % 2 is 1);
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
        return new((int)dizhi % 2 is 1);
    }
}
