using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganRelations.Extensions;
/// <summary>
/// 关于天干关系的扩展。
/// Extensions about Tiangan relations.
/// </summary>
public static class TianganRelationExtensions
{
    /// <summary>
    /// 获取某个天干的四冲关系。
    /// Get the Sichong relation of a Tiangan.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static TianganSichong? SichongRelation(this Tiangan tiangan)
    {
        if (tiangan.Index is 5 or 6)
            return null;
        return new(tiangan);
    }

    /// <summary>
    /// 获取与某个天干形成四冲关系的天干。
    /// Get a Tiangan that can form the Sichong relation with the given one.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Tiangan? Sichong(this Tiangan tiangan)
    {
        return tiangan.Index switch
        {
            < 5 => tiangan.Next(5 + 1),
            >= 7 => tiangan.Next(-1 - 5),
            _ => null
        };
    }

    /// <summary>
    /// 获取某个天干的五合关系。
    /// Get the Wuhe relation of a Tiangan.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static TianganWuhe WuheRelation(this Tiangan tiangan)
    {
        return new(tiangan);
    }

    /// <summary>
    /// 获取与某个天干形成五合关系的天干。
    /// Get a Tiangan that can form the Wuhe relation with the given one.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Tiangan Wuhe(this Tiangan tiangan)
    {
        return tiangan.Next(5);
    }
}
