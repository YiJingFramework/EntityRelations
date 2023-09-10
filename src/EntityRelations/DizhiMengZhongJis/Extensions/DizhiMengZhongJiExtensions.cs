using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiMengZhongJis.Extensions;
/// <summary>
/// 关于地支孟仲季的扩展。
/// Extensions about Dizhis' MengZhongJi.
/// </summary>
public static class DizhiMengZhongJiExtensions
{
    /// <summary>
    /// 获取地支的孟仲季。
    /// Get the Dizhi's MengZhongJi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static MengZhongJi MengZhongJi(this Dizhi dizhi)
    {
        return (MengZhongJi)(dizhi.Index % 12 % 3);
    }
}
