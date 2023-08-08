using YiJingFramework.EntityRelations.WuxingRelations;

namespace YiJingFramework.EntityRelations.EntityStrings.Conversions;

/// <summary>
/// 提供一些针对 <seealso cref="WuxingRelation"/> 的 <seealso cref="EntityToStringConversion{T}"/> 样例。
/// Provides some samples of <seealso cref="EntityToStringConversion{T}"/> of <seealso cref="WuxingRelation"/>s.
/// </summary>
public static class WuxingRelationToStringConversions
{
    /// <summary>
    /// 此转换会返回中文的同我、生我、我生、我克和克我。
    /// This conversion will return 同我, 生我, 我生, 我克 and 克我 in Chinese.
    /// </summary>
    public static EntityToStringConversion<WuxingRelation> InChinese { get; }
        = (relationship) =>
        {
            return relationship switch
            {
                WuxingRelation.SameAsMe => "同我",
                WuxingRelation.GeneratingMe => "生我",
                WuxingRelation.GeneratedByMe => "我生",
                WuxingRelation.OvercameByMe => "我克",
                WuxingRelation.OvercomingMe => "克我",
                _ => relationship.ToString()
            };
        };

    /// <summary>
    /// 此转换会返回 Peer 、 Elder 、 Offspring 、 Wife&amp;Wealth 或 Superior&amp;Spirit 以表示六亲关系。
    /// This conversion will return Peer, Elder, Offspring, Wife&amp;Wealth or Superior&amp;Spirit to represent Liuqin.
    /// </summary>
    public static EntityToStringConversion<WuxingRelation> LiuqinInEnglish { get; }
        = (relationship) =>
        {
            return relationship switch
            {
                WuxingRelation.SameAsMe => "Peer",
                WuxingRelation.GeneratingMe => "Parent",
                WuxingRelation.GeneratedByMe => "Offspring",
                WuxingRelation.OvercameByMe => "Wife&Wealth",
                WuxingRelation.OvercomingMe => "Superior&Spirit",
                _ => relationship.ToString()
            };
        };

    /// <summary>
    /// 此转换会返回兄弟、父母、子孙、妻财或官鬼以表示六亲关系。
    /// This conversion will return 兄弟, 父母, 子孙, 妻财 or 官鬼 to represent Liuqin.
    /// </summary>
    public static EntityToStringConversion<WuxingRelation> Liuqin { get; }
        = (relationship) =>
        {
            return relationship switch
            {
                WuxingRelation.SameAsMe => "兄弟",
                WuxingRelation.GeneratingMe => "父母",
                WuxingRelation.GeneratedByMe => "子孙",
                WuxingRelation.OvercameByMe => "妻财",
                WuxingRelation.OvercomingMe => "官鬼",
                _ => relationship.ToString()
            };
        };
}
