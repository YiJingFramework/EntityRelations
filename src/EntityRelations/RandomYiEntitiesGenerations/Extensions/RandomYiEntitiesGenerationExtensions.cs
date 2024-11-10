using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.RandomYiEntitiesGenerations.Extensions;

/// <summary>
/// 关于随机生成易学实体的扩展。
/// Extensions about generating Yi entities randomly.
/// </summary>
public static class RandomYiEntitiesGenerationExtensions
{
    /// <summary>
    /// 获取随机天干。
    /// Get a random Tiangan.
    /// </summary>
    /// <param name="random">
    /// 随机数生成器。
    /// Random generator.
    /// </param>
    /// <returns>
    /// 天干。
    /// Tiangan.
    /// </returns>
    public static Tiangan NextTiangan(this Random random)
    {
        return (Tiangan)random.Next(10);
    }

    /// <summary>
    /// 获取随机地支。
    /// Get a random Dizhi.
    /// </summary>
    /// <param name="random">
    /// 随机数生成器。
    /// Random generator.
    /// </param>
    /// <returns>
    /// 地支。
    /// Dizhi.
    /// </returns>
    public static Dizhi NextDizhi(this Random random)
    {
        return (Dizhi)random.Next(12);
    }

    /// <summary>
    /// 获取随机干支。
    /// Get a random Ganzhi.
    /// </summary>
    /// <param name="random">
    /// 随机数生成器。
    /// Random generator.
    /// </param>
    /// <returns>
    /// 干支。
    /// Ganzhi.
    /// </returns>
    public static Ganzhi NextGanzhi(this Random random)
    {
        return Ganzhi.FromIndex(random.Next(1, 60 + 1));
    }

    /// <summary>
    /// 获取随机阴阳。
    /// Get a random Yinyang.
    /// </summary>
    /// <param name="random">
    /// 随机数生成器。
    /// Random generator.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// Yinyang.
    /// </returns>
    public static Yinyang NextYinyang(this Random random)
    {
        return new Yinyang(random.Next() > (int.MaxValue / 2));
    }

    /// <summary>
    /// 获取随机六爻卦。
    /// Get a random hexagram Gua.
    /// </summary>
    /// <param name="random">
    /// 随机数生成器。
    /// Random generator.
    /// </param>
    /// <returns>
    /// 六爻卦。
    /// Hexagram Gua.
    /// </returns>
    public static GuaHexagram NextGuaHexagram(this Random random)
    {
        return new GuaHexagram(
            random.NextYinyang(),
            random.NextYinyang(),
            random.NextYinyang(),
            random.NextYinyang(),
            random.NextYinyang(),
            random.NextYinyang());
    }

    /// <summary>
    /// 获取随机三爻卦。
    /// Get a random trigram Gua.
    /// </summary>
    /// <param name="random">
    /// 随机数生成器。
    /// Random generator.
    /// </param>
    /// <returns>
    /// 三爻卦。
    /// Trigram Gua.
    /// </returns>
    public static GuaTrigram NextGuaTrigram(this Random random)
    {
        return new GuaTrigram(
            random.NextYinyang(),
            random.NextYinyang(),
            random.NextYinyang());
    }
}
