// not do this temporarily

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.BranchRelationshipsExtensions;

/// <summary>
/// 关于地支刑冲破害合（六合）的扩展。
/// Extensions about Dizhis' relationships (Xing, Chong, Po, Hai, He (Liuhe)).
/// </summary>
public static class BranchRelationshipsExtensions
{
    /// <summary>
    /// 取六合。
    /// Get a Dizhi's Liuhe.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 六合。
    /// The Liuhe.
    /// </returns>
    public static Dizhi Liuhe(this Dizhi dizhi)
    {
        var index = 1 - (dizhi.Index - 2);
        return new Dizhi(index);
    }

    /// <summary>
    /// 取冲。
    /// Get a Dizhi's Chong.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 冲。
    /// The Chong.
    /// </returns>
    public static Dizhi Chong(this Dizhi dizhi)
    {
        return dizhi.Next(6);
    }

    /// <summary>
    /// 取害。
    /// Get a Dizhi's Hai.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 害。
    /// The Hai.
    /// </returns>
    public static Dizhi Hai(this Dizhi dizhi)
    {
        var index = 10 - (dizhi.Index - 11);
        return new Dizhi(index);
    }

    /// <summary>
    /// 取被刑。
    /// Get the Dizhi that Xings the given one.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The given Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi XingBy(this Dizhi dizhi)
    {
        var index = dizhi.Index switch {
            4 => 1,
            11 => 2,
            6 => 3,
            1 => 4,
            5 => 5,
            9 => 6,
            7 => 7,
            2 => 8,
            3 => 9,
            10 => 10,
            8 => 11,
            _ => 12 // 12
        };
        return new Dizhi(index);
    }

    /// <summary>
    /// 取刑。
    /// Get the Dizhi that be Xinged by the given one.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The given Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi Xing(this Dizhi dizhi)
    {
        var index = dizhi.Index switch {
            1 => 4,
            2 => 11,
            3 => 6,
            4 => 1,
            5 => 5,
            6 => 9,
            7 => 7,
            8 => 2,
            9 => 3,
            10 => 10,
            11 => 8,
            _ => 12 // 12
        };
        return new Dizhi(index);
    }

    /// <summary>
    /// 取破。
    /// Get a Dizhi's Po.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 破。
    /// The Po.
    /// </returns>
    public static Dizhi Po(this Dizhi dizhi)
    {
        var sign = 1 - (dizhi.Index % 2) * 2;
        // odd: -1, even: +1
        return dizhi.Next(3 * sign);
    }
}
*/