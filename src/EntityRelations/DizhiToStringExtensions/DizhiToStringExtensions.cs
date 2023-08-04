using YiJingFramework.EntityRelations.Shared;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiToStringExtensions;

/// <summary>
/// 关于从地支到字符串的转换扩展。
/// Extensions about conversion from Dizhis to strings.
/// </summary>
public static class DizhiToStringExtensions
{
    /// <summary>
    /// 将 <seealso cref="Dizhi"/> 通过指定的转换方法转换为字符串。
    /// Convert <seealso cref="Dizhi"/>s to strings with the given conversion method.
    /// </summary>
    /// <param name="dizhi">
    /// 要转换的地支。
    /// The Dizhi to convert.
    /// </param>
    /// <param name="conversion">
    /// 要用的转换器。
    /// The converter to be used.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static string ToString(
        this Dizhi dizhi,
        ConversionToString<Dizhi>? conversion)
    {
        if (conversion is null)
            return dizhi.ToString();
        return conversion(dizhi);
    }
}
