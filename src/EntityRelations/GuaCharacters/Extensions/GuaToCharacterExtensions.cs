using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelations.GuaCharacters.Extensions;

/// <summary>
/// 关于从卦到 unicode 字符的转换扩展。
/// Extensions about conversion from Guas to unicode characters.
/// </summary>
public static partial class GuaToCharacterExtensions
{
    /// <summary>
    /// 将卦转换为对应的 unicode 字符。
    /// Convert a Gua to its corresponding unicode character.
    /// </summary>
    /// <param name="gua">
    /// 要转换的卦。
    /// The Gua to convert.
    /// </param>
    /// <returns>
    /// 转换结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 是 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static char ToUnicodeChar(this GuaHexagram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);
        
        return GuaToCharacterTables.SwitchToUnicodeChar(gua);
    }

    /// <inheritdoc cref="ToUnicodeChar(GuaHexagram)" />
    public static char ToUnicodeChar(this GuaTrigram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        int value = '\u2630';
        int d = 4;
        foreach (var line in gua)
        {
            if (!line.IsYang)
                value += d;
            d = d / 2;
        }
        return (char)value;
    }

    /// <inheritdoc cref="ToUnicodeChar(GuaHexagram)" />
    public static char ToUnicodeChar(this GuaWith2Lines gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        if (gua[0].IsYang)
            return gua[1].IsYang ? '\u268C' : '\u268D';
        return gua[1].IsYang ? '\u268E' : '\u268F';
    }

    /// <inheritdoc cref="ToUnicodeChar(GuaHexagram)" />
    public static char ToUnicodeChar(this GuaWith1Line gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return gua[0].IsYang ? '\u268A' : '\u268B';
    }

    /// <inheritdoc cref="ToUnicodeChar(GuaHexagram)" />
    /// <exception cref="ArgumentException">
    /// <paramref name="gua"/> 没有对应的 unicode 字符。
    /// <paramref name="gua"/> does not have a corresponding unicode character.
    /// </exception>
    public static char ToUnicodeChar(this Gua gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return gua.Count switch
        {
            1 => ToUnicodeChar(gua.AsFixed<GuaWith1Line>()),
            2 => ToUnicodeChar(gua.AsFixed<GuaWith2Lines>()),
            3 => ToUnicodeChar(gua.AsFixed<GuaTrigram>()),
            6 => ToUnicodeChar(gua.AsFixed<GuaHexagram>()),
            _ => throw new ArgumentException(
                $"There are no corresponding unicode character for the given Gua '{gua}'.", nameof(gua))
        };
    }
}
