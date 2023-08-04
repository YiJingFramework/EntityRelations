using System.Diagnostics.CodeAnalysis;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaToCharacterExtensions;

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

        return SwitchToUnicodeChar(gua);
    }

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
    public static char ToUnicodeChar(this GuaWith2Lines gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        if (gua[0].IsYang)
            return gua[1].IsYang ? '\u268C' : '\u268D';
        return gua[1].IsYang ? '\u268E' : '\u268F';
    }

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
    public static char ToUnicodeChar(this GuaWith1Line gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return gua[0].IsYang ? '\u268A' : '\u268B';
    }

    /// <summary>
    /// 尝试从某个值进行转换。
    /// Try converting from.
    /// </summary>
    /// <param name="value">
    /// 要转换的值。
    /// The value to convert from.
    /// </param>
    /// <param name="result">
    /// 转换结果。
    /// The result.
    /// </param>
    /// <returns>
    /// 指示转换是否成功的值。
    /// A value indicates whether the conversion succeeded or not.
    /// </returns>
    public static bool TryFromUnicodeChar(char value, [MaybeNullWhen(false)] out Gua result)
    {
        switch (value)
        {
            case '\u268A':
                result = new Gua(Yinyang.Yang);
                return true;
            case '\u268B':
                result = new Gua(Yinyang.Yin);
                return true;
            case '\u268C':
                result = new Gua(Yinyang.Yang, Yinyang.Yang);
                return true;
            case '\u268D':
                result = new Gua(Yinyang.Yang, Yinyang.Yin);
                return true;
            case '\u268E':
                result = new Gua(Yinyang.Yin, Yinyang.Yang);
                return true;
            case '\u268F':
                result = new Gua(Yinyang.Yin, Yinyang.Yin);
                return true;
            default:
                break;
        }

        {
            var difference = value - '\u2630';
            if (difference is >= 0 and < 8)
            {
                var first = Yinyang.Yang;
                if (difference >= 4)
                {
                    first = Yinyang.Yin;
                    difference -= 4;
                }

                var second = Yinyang.Yang;
                if (difference >= 2)
                {
                    second = Yinyang.Yin;
                    difference -= 2;
                }

                var third = Yinyang.Yang;
                if (difference >= 1)
                    third = Yinyang.Yin;

                result = new Gua(first, second, third);
                return true;
            }
        }

        {
            var difference = value - '\u4DC0';
            if (difference is >= 0 and < 64)
            {
                result = SwitchFromUnicodeChar(difference);
                return true;
            }
        }

        result = null;
        return false;
    }
}
