using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs.Extensions;
public static class TianganShierZhangshengExtensions
{
    private static (Dizhi, bool) GetZhangshengAndReverse(this Tiangan tiangan)
    {
        return tiangan.Index switch
        {
            1 => (Dizhi.Hai, false),
            3 => (Dizhi.Yin, false),
            5 => (Dizhi.Yin, false),
            7 => (Dizhi.Si, false),
            9 => (Dizhi.Shen, false),
            2 => (Dizhi.Wu, true),
            4 => (Dizhi.You, true),
            6 => (Dizhi.You, true),
            8 => (Dizhi.Zi, true),
            _ => (Dizhi.Mao, true)
        };
    }

    public static ShierZhangshengProvider ShierZhangsheng(this Tiangan tiangan)
    {
        var (zhangsheng, reverse) = GetZhangshengAndReverse(tiangan);
        return new ShierZhangshengProvider(zhangsheng, reverse);
    }

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

    public static ShierZhangsheng ShierZhangsheng(
        this Tiangan tiangan,
        Dizhi dizhi)
    {
        var (zhangsheng, reverse) = GetZhangshengAndReverse(tiangan);
        int difference;
        if (reverse)
            difference = zhangsheng.Index - dizhi.Index;
        else
            difference = dizhi.Index - zhangsheng.Index;
        return (ShierZhangsheng)((difference + 12) % 12);
    }
}
