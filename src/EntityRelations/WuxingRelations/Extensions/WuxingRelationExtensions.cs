using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelations.Extensions;

/// <summary>
/// 关于五行生克关系的扩展。
/// Extensions about Wuxing relationship.
/// </summary>
public static class WuxingRelationExtensions
{
    /// <summary>
    /// 获取与另一五行之间的关系。
    /// Get the relationship between a Wuxing and another Wuxing.
    /// </summary>
    /// <param name="me">
    /// 此五行（我）。
    /// The current Wuxing (me).
    /// </param>
    /// <param name="other">
    /// 另一五行。
    /// The other Wuxing.
    /// </param>
    /// <returns>
    /// 关系。
    /// The relationship.
    /// </returns>
    public static WuxingRelation GetWuxingRelationship(this Wuxing me, Wuxing other)
    {
        return (WuxingRelation)(((int)other - (int)me + 5) % 5);
    }

    /// <summary>
    /// 通过五行关系获取另一五行。
    /// Get another Wuxing with the relationship of a Wuxing.
    /// </summary>
    /// <param name="me">
    /// 此五行（我）。
    /// The current Wuxing (me).
    /// </param>
    /// <param name="relationship">
    /// 关系。
    /// The relationship.
    /// </param>
    /// <returns>
    /// 另一五行。
    /// The another Wuxing.
    /// </returns>
    public static Wuxing GetWuxingThat(this Wuxing me, WuxingRelation relationship)
    {
        return me + (int)relationship;
    }
}
