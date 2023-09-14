using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.EntityStrings.Conversions;

/// <summary>
/// 提供一些针对 <seealso cref="Dizhi"/> 的 <seealso cref="EntityToStringConversion{T}"/> 样例。
/// Provides some samples of <seealso cref="EntityToStringConversion{T}"/> of <seealso cref="Dizhi"/>s.
/// </summary>
public static class DizhiToStringConversions
{
    /// <summary>
    /// 此转换会以中文返回的地支对应的生肖。
    /// 分别为鼠、牛、虎、兔、龙、蛇、马、羊、猴、鸡、狗和猪。
    /// This conversion will return the corresponding Shengxiao of a Dizhi in Chinese.
    /// They will be 鼠, 牛, 虎, 兔, 龙, 蛇, 马, 羊, 猴, 鸡, 狗 and 猪 .
    /// </summary>
    public static EntityToStringConversion<Dizhi> Shengxiao { get; }
        = (dizhi) =>
        {
            return (int)dizhi switch
            {
                0 => "鼠",
                1 => "牛",
                2 => "虎",
                3 => "兔",
                4 => "龙",
                5 => "蛇",
                6 => "马",
                7 => "羊",
                8 => "猴",
                9 => "鸡",
                10 => "狗",
                _ => "猪"
            };
        };

    /// <summary>
    /// 此转换会以英文返回的地支对应的生肖。
    /// 分别为 Rat 、 Cow 、 Tiger 、 Rabbit 、 Long 、 Snake 、 Horse 、 Sheep 、 Monkey 、 Chicken 、 Dog 和 Pig 。
    /// This conversion will return the corresponding Shengxiao of a Dizhi in English.
    /// They will be Rat, Cow, Tiger, Rabbit, Long, Snake, Horse, Sheep, Monkey, Chicken, Dog and Pig.
    /// </summary>
    public static EntityToStringConversion<Dizhi> ShengxiaoInEnglish { get; }
        = (dizhi) =>
        {
            return (int)dizhi switch
            {
                0 => "Rat",
                1 => "Cow",
                2 => "Tiger",
                3 => "Rabbit",
                4 => "Long",
                5 => "Snake",
                6 => "Horse",
                7 => "Sheep",
                8 => "Monkey",
                9 => "Chicken",
                10 => "Dog",
                _ => "Pig"
            };
        };
}
