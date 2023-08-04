using System.Diagnostics;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;

/// <summary>
/// 关于八卦阴阳的扩展。
/// Extensions about Yinyang attribute of Guas (trigrams).
/// </summary>
public static class GuaTrigramYinyangExtensions
{
    internal static Yinyang YinyangOfCheckedTrigram(int guaHash)
    {
        Debug.Assert(guaHash is >= 0b1000 and <= 0b1111);
        return guaHash switch
        {
            0b1_000 => PrimitiveTypes.Yinyang.Yin,
            0b1_100 => PrimitiveTypes.Yinyang.Yang,
            0b1_010 => PrimitiveTypes.Yinyang.Yang,
            0b1_110 => PrimitiveTypes.Yinyang.Yin,
            0b1_001 => PrimitiveTypes.Yinyang.Yang,
            0b1_101 => PrimitiveTypes.Yinyang.Yin,
            0b1_011 => PrimitiveTypes.Yinyang.Yin,
            _ => PrimitiveTypes.Yinyang.Yang, // 0b111
        };
    }

    /// <summary>
    /// 获取卦的阴阳。
    /// Get the Yinyang attribute of a Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// The Yinyang.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 是 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Yinyang Yinyang(this GuaTrigram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return YinyangOfCheckedTrigram(gua.GetHashCode());
    }
}
