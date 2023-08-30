using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelations;

/// <summary>
/// <seealso cref="Wuxing"/> 的生克关系。
/// The relationships between <seealso cref="Wuxing"/>s.
/// </summary>
public enum WuxingRelation
{
    /// <summary>
    /// 同“我”者。
    /// Wuxing that is the same as 'me'.
    /// </summary>
    SameAsMe = 0,
    /// <summary>
    /// 生“我”者。
    /// Wuxing that Sheng-s 'me'.
    /// </summary>
    ShengsMe = -1 + 5,
    /// <summary>
    /// “我”生者。
    /// Wuxing that is Sheng-ed by 'me'.
    /// </summary>
    IsShengedByMe = +1,
    /// <summary>
    /// “我”克者。
    /// Wuxing that is Ke-ed by 'me'.
    /// </summary>
    IsKeedByMe = +2,
    /// <summary>
    /// 克“我”者。
    /// Wuxing that Ke-s 'me'.
    /// </summary>
    KesMe = -2 + 5,
}
