using System.Diagnostics;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;

/// <summary>
/// 关于八卦五行的扩展。
/// Extensions about Wuxing attribute of Guas (trigrams).
/// </summary>
public static class GuaTrigramWuxingExtensions
{
    internal static Wuxing WuxingOfCheckedTrigram(int guaHash)
    {
        Debug.Assert(guaHash is >= 0b1000 and <= 0b1111);
        return guaHash switch
        {
            0b1_000 => PrimitiveTypes.Wuxing.Earth,
            0b1_100 => PrimitiveTypes.Wuxing.Wood,
            0b1_010 => PrimitiveTypes.Wuxing.Water,
            0b1_110 => PrimitiveTypes.Wuxing.Metal,
            0b1_001 => PrimitiveTypes.Wuxing.Earth,
            0b1_101 => PrimitiveTypes.Wuxing.Fire,
            0b1_011 => PrimitiveTypes.Wuxing.Wood,
            _ => PrimitiveTypes.Wuxing.Metal, // 0b111
        };
    }

    /// <summary>
    /// 获取八卦的五行。
    /// Get the Wuxing attribute of a Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <returns>
    /// 五行。
    /// The Wuxing.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 是 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Wuxing Wuxing(this GuaTrigram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return WuxingOfCheckedTrigram(gua.GetHashCode());
    }
}
