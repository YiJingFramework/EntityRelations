﻿using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.WuxingRelationshipExtensions;

/// <summary>
/// <seealso cref="Wuxing"/> 的生克关系。
/// The relationships between <seealso cref="Wuxing"/>s.
/// </summary>
public enum WuxingRelationship
{
    /// <summary>
    /// 同“我”者。
    /// Wuxing that is the same as 'me'.
    /// </summary>
    SameAsMe = 0,
    /// <summary>
    /// 生“我”者。
    /// Wuxing that generates 'me'.
    /// </summary>
    GeneratingMe = -1 + 5,
    /// <summary>
    /// “我”生者。
    /// Wuxing generated by 'me'.
    /// </summary>
    GeneratedByMe = +1,
    /// <summary>
    /// “我”克者。
    /// Wuxing overcame by 'me'.
    /// </summary>
    OvercameByMe = +2,
    /// <summary>
    /// 克“我”者。
    /// Wuxing that overcomes 'me'.
    /// </summary>
    OvercomingMe = -2 + 5,
}
