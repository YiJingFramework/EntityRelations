using System.Diagnostics;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaHexagramBagongs.Extensions;

/// <summary>
/// 关于六爻卦八宫甲的扩展。
/// Extensions about Guas' (Hexagram) Bagong.
/// </summary>
public static class GuaHexagramBagongExtensions
{
    /// <summary>
    /// 获取六爻卦的八宫和世应。
    /// Get a Gua's (Hexagram) Bagong and Shiying.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static (Bagong gong, Shiying shi) Bagong(this GuaHexagram gua)
    {
        var guaByte = gua.AsGua().ToBytes()[0];
        var upper = (guaByte & 0b111_000) >> 3;
        var lower = guaByte & 0b111;

        if (upper == lower)
            return (new(upper), Shiying.Bachun);

        lower ^= 0b001;
        if (upper == lower)
            return (new(upper), Shiying.Yishi);

        lower ^= 0b010;
        if (upper == lower)
            return (new(upper), Shiying.Ershi);

        lower ^= 0b100;
        if (upper == lower)
            return (new(upper), Shiying.Sanshi);

        upper ^= 0b001;
        if (upper == lower)
            return (new(upper), Shiying.Sishi);

        upper ^= 0b010;
        if (upper == lower)
            return (new(upper), Shiying.Wushi);

        upper ^= 0b001;
        if (upper == lower)
            return (new(upper), Shiying.Youhun);

        Debug.Assert(upper == (lower ^ 0b111));
        return (new(upper), Shiying.Guihun);
    }
}
