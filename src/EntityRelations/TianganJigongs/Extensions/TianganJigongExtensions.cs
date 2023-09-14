using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganJigongs.Extensions;

/// <summary>
/// 关于天干寄宫的扩展。
/// Extensions about Tiangans' Jigong.
/// </summary>
public static class TianganJigongExtensions
{
    /// <summary>
    /// 获取天干的寄宫。
    /// Get the Tiangan's Jigong.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi Jigong(this Tiangan tiangan)
    {
        return (int)tiangan switch
        {
            0 => Dizhi.Yin,
            1 => Dizhi.Chen,
            2 or 4 => Dizhi.Si,
            3 or 5 => Dizhi.Wei,
            6 => Dizhi.Shen,
            7 => Dizhi.Xu,
            8 => Dizhi.Hai,
            _ => Dizhi.Chou
        };
    }
}
