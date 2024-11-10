using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis.Extensions;

/// <summary>
/// 关于年上起月的扩展。
/// Extensions about getting Yues of a Nian.
/// </summary>
public static class GanzhiNianYuesAndRiShisExtensions
{
    /// <summary>
    /// 年上起月。
    /// Get all Yues of a Nian.
    /// </summary>
    /// <param name="niangan">
    /// 年。
    /// Nian.
    /// </param>
    /// <returns>
    /// 年中各月。
    /// Yues in a Nian.
    /// </returns>
    public static TianganNianYuesList AsNianGetYues(this Tiangan niangan)
    {
        return new TianganNianYuesList(niangan);
    }

    /// <summary>
    /// 日上起时。
    /// Get all Shis of a Ri.
    /// </summary>
    /// <param name="niangan">
    /// 日。
    /// Ri.
    /// </param>
    /// <returns>
    /// 日中各时。
    /// Shis in a Ri.
    /// </returns>
    public static TianganRiShisList AsRiGetShis(this Tiangan niangan)
    {
        return new TianganRiShisList(niangan);
    }
}
