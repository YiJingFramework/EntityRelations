using System.Collections.Immutable;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaHexagramNajias.Extensions;

/// <summary>
/// 关于六爻卦纳甲的扩展。
/// Extensions about Guas' (Hexagram) Najia.
/// </summary>
public static class GuaHexagramNajiaExtensions
{
    /// <summary>
    /// 获取六爻卦的纳甲。
    /// Get a Gua's (Hexagram) Najia.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static IReadOnlyList<Ganzhi> Najia(this GuaHexagram gua)
    {
        var result = ImmutableArray.CreateBuilder<Ganzhi>(6);
        var guaByte = gua.AsGua().ToBytes()[0];

        var trigram = guaByte & 0b111;
        var (tiangan, dizhi, direction) = trigram switch
        {
            0b111 => (Tiangan.Jia, Dizhi.Zi, 2),
            0b011 => (Tiangan.Ding, Dizhi.Si, -2),
            0b101 => (Tiangan.Ji, Dizhi.Mao, -2),
            0b001 => (Tiangan.Geng, Dizhi.Zi, 2),
            0b110 => (Tiangan.Xin, Dizhi.Chou, -2),
            0b010 => (Tiangan.Wu, Dizhi.Yin, 2),
            0b100 => (Tiangan.Bing, Dizhi.Chen, 2),
            _ => (Tiangan.Yi, Dizhi.Wei, -2)
        };
        result.Add(Ganzhi.FromGanzhi(tiangan, dizhi));
        dizhi = dizhi.Next(direction);
        result.Add(Ganzhi.FromGanzhi(tiangan, dizhi));
        dizhi = dizhi.Next(direction);
        result.Add(Ganzhi.FromGanzhi(tiangan, dizhi));

        trigram = guaByte & 0b111_000;
        (tiangan, dizhi, direction) = trigram switch
        {
            0b111_000 => (Tiangan.Ren, Dizhi.Wu, 2),
            0b011_000 => (Tiangan.Ding, Dizhi.Hai, -2),
            0b101_000 => (Tiangan.Ji, Dizhi.You, -2),
            0b001_000 => (Tiangan.Geng, Dizhi.Wu, 2),
            0b110_000 => (Tiangan.Xin, Dizhi.Wei, -2),
            0b010_000 => (Tiangan.Wu, Dizhi.Shen, 2),
            0b100_000 => (Tiangan.Bing, Dizhi.Xu, 2),
            _ => (Tiangan.Gui, Dizhi.Chou, -2)
        };
        result.Add(Ganzhi.FromGanzhi(tiangan, dizhi));
        dizhi = dizhi.Next(direction);
        result.Add(Ganzhi.FromGanzhi(tiangan, dizhi));
        dizhi = dizhi.Next(direction);
        result.Add(Ganzhi.FromGanzhi(tiangan, dizhi));

        return result.MoveToImmutable();
    }
}
