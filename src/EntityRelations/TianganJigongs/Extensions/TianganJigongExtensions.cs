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
        return tiangan.Index switch
        {
            1 => Dizhi.Yin,
            2 => Dizhi.Chen,
            3 or 5 => Dizhi.Si,
            4 or 6 => Dizhi.Wei,
            7 => Dizhi.Shen,
            8 => Dizhi.Xu,
            9 => Dizhi.Hai,
            _ => Dizhi.Chou
        };
    }
}
