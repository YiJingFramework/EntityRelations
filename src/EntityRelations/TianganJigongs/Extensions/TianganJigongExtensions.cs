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
        return new(tiangan.Index switch
        {
            1 => 3,
            2 => 5,
            3 or 5 => 6,
            4 or 6 => 8,
            7 => 9,
            8 => 11,
            9 => 12,
            _ => 2
        });
    }
}
