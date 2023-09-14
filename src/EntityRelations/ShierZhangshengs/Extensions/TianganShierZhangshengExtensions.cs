using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs.Extensions;

/// <summary>
/// 关于天干十二长生的扩展。
/// Extensions about Tiangans' Shier Zhangshengs.
/// </summary>
public static class TianganShierZhangshengExtensions
{
    private static (Dizhi, bool) GetZhangshengAndReverse(Tiangan tiangan)
    {
        return (int)tiangan switch
        {
            0 => (Dizhi.Hai, false),
            2 => (Dizhi.Yin, false),
            4 => (Dizhi.Yin, false),
            6 => (Dizhi.Si, false),
            8 => (Dizhi.Shen, false),
            1 => (Dizhi.Wu, true),
            3 => (Dizhi.You, true),
            5 => (Dizhi.You, true),
            7 => (Dizhi.Zi, true),
            _ => (Dizhi.Mao, true)
        };
    }

    /// <summary>
    /// 获取天干的十二长生提供器。
    /// Get the Shier Zhangsheng provider of a Tiangan.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static ShierZhangshengProvider ShierZhangsheng(this Tiangan tiangan)
    {
        var (zhangsheng, reverse) = GetZhangshengAndReverse(tiangan);
        return new ShierZhangshengProvider(zhangsheng, reverse);
    }

    /// <summary>
    /// 获取给定天干的指定十二长生。
    /// Get the specific Shier Zhangsheng of the given Tiangan.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <param name="shierZhangsheng">
    /// 十二长生。
    /// The Shier Zhangsheng.
    /// </param>
    /// <returns>
    /// 地支。
    /// The Dizhi.
    /// </returns>
    public static Dizhi ShierZhangsheng(
        this Tiangan tiangan,
        ShierZhangsheng shierZhangsheng)
    {
        var (zhangsheng, reverse) = GetZhangshengAndReverse(tiangan);
        if (reverse)
            return zhangsheng.Next(-(int)shierZhangsheng);
        else
            return zhangsheng.Next((int)shierZhangsheng);
    }

    /// <summary>
    /// 判断指定的地支是给定天干的哪个十二长生。
    /// Determine which Shier Zhangsheng of the given Tiangan the specific Dizhi is.
    /// </summary>
    /// <param name="tiangan">
    /// 天干。
    /// The Tiangan.
    /// </param>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 十二长生。
    /// The Shier Zhangsheng.
    /// </returns>
    public static ShierZhangsheng ShierZhangsheng(
        this Tiangan tiangan,
        Dizhi dizhi)
    {
        var (zhangsheng, reverse) = GetZhangshengAndReverse(tiangan);
        int difference;
        if (reverse)
            difference = (int)zhangsheng - (int)dizhi;
        else
            difference = (int)dizhi - (int)zhangsheng;
        return (ShierZhangsheng)((difference + 12) % 12);
    }
}
