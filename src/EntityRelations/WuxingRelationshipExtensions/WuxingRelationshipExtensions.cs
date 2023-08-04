using YiJingFramework.EntityRelations.Shared;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelationshipExtensions;

/// <summary>
/// 关于五行生克关系的扩展。
/// Extensions about Wuxing relationship.
/// </summary>
public static class WuxingRelationshipExtensions
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
    public static WuxingRelationship GetWuxingRelationship(this Wuxing me, Wuxing other)
    {
        return (WuxingRelationship)(((int)other - (int)me + 5) % 5);
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
    public static Wuxing GetWuxingThat(this Wuxing me, WuxingRelationship relationship)
    {
        return me + (int)relationship;
    }

    /// <summary>
    /// 将 <seealso cref="WuxingRelationship"/> 通过指定的转换方法转换为字符串。
    /// Convert <seealso cref="WuxingRelationship"/>s to strings with the given conversion method.
    /// </summary>
    /// <param name="relationship">
    /// 要转换的五行关系。
    /// The relationship to convert.
    /// </param>
    /// <param name="conversion">
    /// 要用的转换器。
    /// The converter to be used.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static string ToString(
        this WuxingRelationship relationship,
        ConversionToString<WuxingRelationship>? conversion)
    {
        if (conversion is null)
            return relationship.ToString();
        return conversion(relationship);
    }
}
