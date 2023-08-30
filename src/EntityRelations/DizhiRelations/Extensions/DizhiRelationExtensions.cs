using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations.Extensions;
/// <summary>
/// 关于地支关系的扩展。
/// Extensions about Dizhi relations.
/// </summary>
public static class DizhiRelationExtensions
{
    /// <summary>
    /// 获取某个地支的六冲关系。
    /// Get the Liuchong relation of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static DizhiLiuchong LiuchongRelation(this Dizhi dizhi)
    {
        return new(dizhi);
    }
    /// <summary>
    /// 获取与某个地支形成六冲关系的地支。
    /// Get a Dizhi that can form the Liuchong relation with the given one.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi Liuchong(this Dizhi dizhi)
    {
        return dizhi.Next(6);
    }

    /// <summary>
    /// 获取某个地支的六害关系。
    /// Get the Liuhai relation of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static DizhiLiuhai LiuhaiRelation(this Dizhi dizhi)
    {
        return new(dizhi);
    }
    /// <summary>
    /// 获取与某个地支形成六害关系的地支。
    /// Get a Dizhi that can form the Liuhai relation with the given one.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi Liuhai(this Dizhi dizhi)
    {
        return (Dizhi)(4 - ((int)dizhi - 5));
    }

    /// <summary>
    /// 获取某个地支的六合关系。
    /// Get the Liuhe relation of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static DizhiLiuhe LiuheRelation(this Dizhi dizhi)
    {
        return new(dizhi);
    }
    /// <summary>
    /// 获取与某个地支形成六合关系的地支。
    /// Get a Dizhi that can form the Liuhe relation with the given one.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi Liuhe(this Dizhi dizhi)
    {
        return (Dizhi)(1 - ((int)dizhi - 2));
    }

    /// <summary>
    /// 获取某个地支的六破关系。
    /// Get the Liupo relation of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static DizhiLiupo LiupoRelation(this Dizhi dizhi)
    {
        return new(dizhi);
    }
    /// <summary>
    /// 获取与某个地支形成六破关系的地支。
    /// Get a Dizhi that can form the Liupo relation with the given one.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi Liupo(this Dizhi dizhi)
    {
        if ((int)dizhi is 1 or 3 or 5 or 7 or 9 or 11)
            return dizhi.Next(-3);
        else
            return dizhi.Next(3);
    }

    /// <summary>
    /// 获取某个地支的三合关系。
    /// Get the Sanhe relation of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static DizhiSanhe SanheRelation(this Dizhi dizhi)
    {
        return new(dizhi);
    }

    /// <summary>
    /// 获取某个地支的三会关系。
    /// Get the Sanhui relation of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static DizhiSanhui SanhuiRelation(this Dizhi dizhi)
    {
        return new(dizhi);
    }

    /// <summary>
    /// 获取某个地支的三刑关系。
    /// Get the Sanxing relation of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static DizhiSanxing SanxingRelation(this Dizhi dizhi)
    {
        return new(dizhi);
    }
}
