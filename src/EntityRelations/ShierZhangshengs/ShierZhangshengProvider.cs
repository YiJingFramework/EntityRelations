using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.ShierZhangshengs;

/// <summary>
/// 十二长生提供器。
/// A Shier Zhangshengs' provider.
/// </summary>
public sealed class ShierZhangshengProvider
{
    private readonly Dizhi zhangsheng;
    private readonly bool reverse;

    /// <summary>
    /// 创建一个 <seealso cref="ShierZhangshengProvider"/> 的实例。
    /// Create an instance of <seealso cref="ShierZhangshengProvider"/>.
    /// </summary>
    /// <param name="zhangsheng">
    /// 长生所对应的地支。
    /// The corresponding Dizhi of Zhangsheng.
    /// </param>
    /// <param name="reverse">
    /// 逆行。
    /// Goes in the reverse order.
    /// </param>
    public ShierZhangshengProvider(Dizhi zhangsheng, bool reverse)
    {
        this.zhangsheng = zhangsheng;
        this.reverse = reverse;
    }

    /// <summary>
    /// 获取指定十二长生所对应的地支。
    /// Get the corresponding Dizhi of the given Shier Zhangsheng.
    /// </summary>
    /// <param name="shierZhangsheng">
    /// 十二长生。
    /// The Shier Zhangsheng.
    /// </param>
    /// <returns>
    /// 地支。
    /// The Dizhi.
    /// </returns>
    public Dizhi this[ShierZhangsheng shierZhangsheng]
    {
        get
        {
            if (reverse)
                return zhangsheng.Next(-(int)shierZhangsheng);
            else
                return zhangsheng.Next((int)shierZhangsheng);
        }
    }

    /// <summary>
    /// 获取指定地支所对应的十二长生。
    /// Get the corresponding Shier Zhangsheng of the given Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 十二长生。
    /// The Shier Zhangsheng.
    /// </returns>
    public ShierZhangsheng this[Dizhi dizhi]
    {
        get
        {
            int difference;
            if (reverse)
                difference = zhangsheng.Index - dizhi.Index;
            else
                difference = dizhi.Index - zhangsheng.Index;
            return (ShierZhangsheng)((difference + 12) % 12);
        }
    }
}