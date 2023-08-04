using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.EntityStrings.Conversions;

/// <summary>
/// 提供一些针对 <seealso cref="Dizhi"/> 的 <seealso cref="ConversionToString{T}"/> 样例。
/// Provides some samples of <seealso cref="ConversionToString{T}"/> of <seealso cref="Dizhi"/>s.
/// </summary>
public static class DizhiToStringConversions
{
    /// <summary>
    /// 此转换会以中文返回的地支对应的生肖。
    /// 分别为鼠、牛、虎、兔、龙、蛇、马、羊、猴、鸡、狗和猪。
    /// This conversion will return the corresponding Shengxiao of a Dizhi in Chinese.
    /// They will be 鼠, 牛, 虎, 兔, 龙, 蛇, 马, 羊, 猴, 鸡, 狗 and 猪 .
    /// </summary>
    public static ConversionToString<Dizhi> Shengxiao { get; }
        = (dizhi) =>
        {
            return dizhi.Index switch
            {
                1 => "鼠",
                2 => "牛",
                3 => "虎",
                4 => "兔",
                5 => "龙",
                6 => "蛇",
                7 => "马",
                8 => "羊",
                9 => "猴",
                10 => "鸡",
                11 => "狗",
                _ => "猪" // 12
            };
        };

    /// <summary>
    /// 此转换会以英文返回的地支对应的生肖。
    /// 分别为 Rat 、 Cow 、 Tiger 、 Rabbit 、 Long 、 Snake 、 Horse 、 Sheep 、 Monkey 、 Chicken 、 Dog 和 Pig 。
    /// This conversion will return the corresponding Shengxiao of a Dizhi in English.
    /// They will be Rat, Cow, Tiger, Rabbit, Long, Snake, Horse, Sheep, Monkey, Chicken, Dog and Pig.
    /// </summary>
    public static ConversionToString<Dizhi> ShengxiaoInEnglish { get; }
        = (dizhi) =>
        {
            return dizhi.Index switch
            {
                1 => "Rat",
                2 => "Cow",
                3 => "Tiger",
                4 => "Rabbit",
                5 => "Long",
                6 => "Snake",
                7 => "Horse",
                8 => "Sheep",
                9 => "Monkey",
                10 => "Chicken",
                11 => "Dog",
                _ => "Pig" // 12
            };
        };
}
