using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs.Extensions;
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

    public static ShierZhangshengProvider ShierZhangsheng(
        this Wuxing wuxing,
        bool earthFollowsWaterOrFire = true)
    {
        var zhangsheng = GetZhangsheng(wuxing, earthFollowsWaterOrFire);
        return new ShierZhangshengProvider(zhangsheng, false);
    }

    public static Dizhi ShierZhangsheng(
        this Wuxing wuxing,
        ShierZhangsheng shierZhangsheng,
        bool earthFollowsWaterOrFire = true)
    {
        var zhangsheng = GetZhangsheng(wuxing, earthFollowsWaterOrFire);
        return zhangsheng.Next((int)shierZhangsheng);
    }

    public static ShierZhangsheng ShierZhangsheng(
        this Wuxing wuxing,
        Dizhi dizhi,
        bool earthFollowsWaterOrFire = true)
    {
        var zhangsheng = GetZhangsheng(wuxing, earthFollowsWaterOrFire);
        int difference = zhangsheng.Index - dizhi.Index;
        return (ShierZhangsheng)((difference + 12) % 12);
    }
}
