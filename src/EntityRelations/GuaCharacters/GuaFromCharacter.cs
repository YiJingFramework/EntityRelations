using System.Diagnostics.CodeAnalysis;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaCharacters;

/// <summary>
/// 关于从 unicode 字符回到卦的转换。
/// Conversion back from unicode characters to Guas.
/// </summary>
public static partial class GuaFromCharacter
{
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
    public static bool TryConvert(char value, [MaybeNullWhen(false)] out Gua result)
    {
        if (TryConvert(value, out GuaWith1Yao? gua1))
        {
            result = gua1.AsGua();
            return true;
        }
        if (TryConvert(value, out GuaWith2Yaos? gua2))
        {
            result = gua2.AsGua();
            return true;
        }
        if (TryConvert(value, out GuaTrigram? gua3))
        {
            result = gua3.AsGua();
            return true;
        }
        if (TryConvert(value, out GuaHexagram? gua6))
        {
            result = gua6.AsGua();
            return true;
        }
        result = null;
        return false;
    }

    /// <inheritdoc cref="TryConvert(char, out Gua)"/>
    public static bool TryConvert(char value, [MaybeNullWhen(false)] out GuaWith1Yao result)
    {
        switch (value)
        {
            case '\u268A':
                result = new(Yinyang.Yang);
                return true;
            case '\u268B':
                result = new(Yinyang.Yin);
                return true;
            default:
                result = null;
                return false;
        }
    }

    /// <inheritdoc cref="TryConvert(char, out Gua)"/>
    public static bool TryConvert(char value, [MaybeNullWhen(false)] out GuaWith2Yaos result)
    {
        switch (value)
        {
            case '\u268C':
                result = new(Yinyang.Yang, Yinyang.Yang);
                return true;
            case '\u268D':
                result = new(Yinyang.Yang, Yinyang.Yin);
                return true;
            case '\u268E':
                result = new(Yinyang.Yin, Yinyang.Yang);
                return true;
            case '\u268F':
                result = new(Yinyang.Yin, Yinyang.Yin);
                return true;
            default:
                result = null;
                return false;
        }
    }

    /// <inheritdoc cref="TryConvert(char, out Gua)"/>
    public static bool TryConvert(char value, [MaybeNullWhen(false)] out GuaTrigram result)
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

            result = new GuaTrigram(first, second, third);
            return true;
        }

        result = null;
        return false;
    }

    /// <inheritdoc cref="TryConvert(char, out Gua)"/>
    public static bool TryConvert(char value, [MaybeNullWhen(false)] out GuaHexagram result)
    {
        var difference = value - '\u4DC0';
        if (difference is >= 0 and < 64)
        {
            result = GuaToCharacterTables.SwitchFromUnicodeChar(difference);
            return true;
        }

        result = null;
        return false;
    }
}
