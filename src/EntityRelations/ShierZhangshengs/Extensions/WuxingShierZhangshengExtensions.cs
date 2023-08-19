using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs.Extensions;

/// <summary>
/// 关于天干十二长生的扩展。
/// Extensions about Wuxings' Shier Zhangshengs.
/// </summary>
public static class WuxingShierZhangshengExtensions
{
    private static Dizhi GetZhangsheng(Wuxing wuxing, bool earthFollowsWaterOrFire)
    {
        return (int)wuxing switch
        {
            0 => Dizhi.Hai,
            1 => Dizhi.Yin,
            3 => Dizhi.Si,
            4 => Dizhi.Shen,
            _ => earthFollowsWaterOrFire ? Dizhi.Shen : Dizhi.Yin
        };
    }

    /// <summary>
    /// 获取五行的十二长生提供器。
    /// Get the Shier Zhangsheng provider of a Wuxing.
    /// </summary>
    /// <param name="wuxing">
    /// 五行。
    /// The Wuxing.
    /// </param>
    /// <param name="earthFollowsWaterOrFire">
    /// 指定土是从水还是从火。
    /// <c>true</c> 表示从水， <c>false</c> 表示从火。
    /// Indicate whether Earth should be the same as Water or as Fire.
    /// <c>true</c> means following Water, while <c>false</c> means Fire.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static ShierZhangshengProvider ShierZhangsheng(
        this Wuxing wuxing,
        bool earthFollowsWaterOrFire = true)
    {
        var zhangsheng = GetZhangsheng(wuxing, earthFollowsWaterOrFire);
        return new ShierZhangshengProvider(zhangsheng, false);
    }

    /// <summary>
    /// 获取给定五行的指定十二长生。
    /// Get the specific Shier Zhangsheng of the given Wuxing.
    /// </summary>
    /// <param name="wuxing">
    /// 五行。
    /// The Wuxing.
    /// </param>
    /// <param name="shierZhangsheng">
    /// 十二长生。
    /// The Shier Zhangsheng.
    /// </param>
    /// <param name="earthFollowsWaterOrFire">
    /// 指定土是从水还是从火。
    /// <c>true</c> 表示从水， <c>false</c> 表示从火。
    /// Indicate whether Earth should be the same as Water or as Fire.
    /// <c>true</c> means following Water, while <c>false</c> means Fire.
    /// </param>
    /// <returns>
    /// 地支。
    /// The Dizhi.
    /// </returns>
    public static Dizhi ShierZhangsheng(
        this Wuxing wuxing,
        ShierZhangsheng shierZhangsheng,
        bool earthFollowsWaterOrFire = true)
    {
        var zhangsheng = GetZhangsheng(wuxing, earthFollowsWaterOrFire);
        return zhangsheng.Next((int)shierZhangsheng);
    }

    /// <summary>
    /// 判断指定的地支是给定五行的哪个十二长生。
    /// Determine which Shier Zhangsheng of the given Wuxing the specific Dizhi is.
    /// </summary>
    /// <param name="wuxing">
    /// 五行。
    /// The Wuxing.
    /// </param>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <param name="earthFollowsWaterOrFire">
    /// 指定土是从水还是从火。
    /// <c>true</c> 表示从水， <c>false</c> 表示从火。
    /// Indicate whether Earth should be the same as Water or as Fire.
    /// <c>true</c> means following Water, while <c>false</c> means Fire.
    /// </param>
    /// <returns>
    /// 十二长生。
    /// The Shier Zhangsheng.
    /// </returns>
    public static ShierZhangsheng ShierZhangsheng(
        this Wuxing wuxing,
        Dizhi dizhi,
        bool earthFollowsWaterOrFire = true)
    {
        var zhangsheng = GetZhangsheng(wuxing, earthFollowsWaterOrFire);
        int difference = dizhi.Index - zhangsheng.Index;
        return (ShierZhangsheng)((difference + 12) % 12);
    }
}
