using YiJingFramework.EntityRelations.Shared;

namespace YiJingFramework.EntityRelations.WuxingRelationshipExtensions;

/// <summary>
/// 提供一些针对 <seealso cref="WuxingRelationship"/> 的 <seealso cref="ConversionToString{T}"/> 样例。
/// Provides some samples of <seealso cref="ConversionToString{T}"/> of <seealso cref="WuxingRelationship"/>s.
/// </summary>
public static class WuxingRelationshipToStringConversions
{
    /// <summary>
    /// 此转换会返回中文的同我、生我、我生、我克和克我。
    /// This conversion will return 同我, 生我, 我生, 我克 and 克我 in Chinese.
    /// </summary>
    public static ConversionToString<WuxingRelationship> InChinese { get; }
        = (relationship) => {
            return relationship switch {
                WuxingRelationship.SameAsMe => "同我",
                WuxingRelationship.GeneratingMe => "生我",
                WuxingRelationship.GeneratedByMe => "我生",
                WuxingRelationship.OvercameByMe => "我克",
                WuxingRelationship.OvercomingMe => "克我",
                _ => relationship.ToString()
            };
        };

    /// <summary>
    /// 此转换会返回 Peer 、 Elder 、 Offspring 、 Wife&amp;Wealth 或 Superior&amp;Spirit 以表示六亲关系。
    /// This conversion will return Peer, Elder, Offspring, Wife&amp;Wealth or Superior&amp;Spirit to represent Liuqin.
    /// </summary>
    public static ConversionToString<WuxingRelationship> LiuqinInEnglish { get; }
        = (relationship) => {
            return relationship switch {
                WuxingRelationship.SameAsMe => "Peer",
                WuxingRelationship.GeneratingMe => "Parent",
                WuxingRelationship.GeneratedByMe => "Offspring",
                WuxingRelationship.OvercameByMe => "Wife&Wealth",
                WuxingRelationship.OvercomingMe => "Superior&Spirit",
                _ => relationship.ToString()
            };
        };

    /// <summary>
    /// 此转换会返回兄弟、父母、子孙、妻财或官鬼以表示六亲关系。
    /// This conversion will return 兄弟, 父母, 子孙, 妻财 or 官鬼 to represent Liuqin.
    /// </summary>
    public static ConversionToString<WuxingRelationship> Liuqin { get; }
        = (relationship) => {
            return relationship switch {
                WuxingRelationship.SameAsMe => "兄弟",
                WuxingRelationship.GeneratingMe => "父母",
                WuxingRelationship.GeneratedByMe => "子孙",
                WuxingRelationship.OvercameByMe => "妻财",
                WuxingRelationship.OvercomingMe => "官鬼",
                _ => relationship.ToString()
            };
        };
}
