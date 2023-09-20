using System.Diagnostics;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelations.GuaHexagramBagongs;

/// <summary>
/// 六爻卦八宫。
/// Bagong of Guas (Hexagrams).
/// </summary>
public sealed class Bagong : IEquatable<Bagong>, IComparable<Bagong>
{
    /// <summary>
    /// 八宫。
    /// The Bagong.
    /// </summary>
    public GuaTrigram Gong { get; }

    internal Bagong(int gongIntChecked)
    {
        Debug.Assert(gongIntChecked is >= 0b000 and <= 0b111);
        gongIntChecked |= 0b1_000;
        var result = Gua.FromBytes((byte)gongIntChecked);
        this.Gong = new GuaTrigram(result);
    }
    /// <summary>
    /// 创建一个 <seealso cref="Bagong"/> 的实例。
    /// Initialize a new instance of <seealso cref="Bagong"/>.
    /// </summary>
    /// <param name="gong">
    /// 八宫。
    /// The Bagong.
    /// </param>
    public Bagong(GuaTrigram gong)
    {
        this.Gong = gong;
    }

    /// <summary>
    /// 根据世应取此宫中的卦。
    /// Get the Gua of this Bagong with the given Shiying.
    /// </summary>
    /// <param name="shiying">
    /// 世应。
    /// The Shiying.
    /// </param>
    /// <returns>
    /// 卦。
    /// The Gua.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="shiying"/> 的值不正确。
    /// The value of <paramref name="shiying"/> is invalid.
    /// </exception>
    public GuaHexagram this[Shiying shiying]
    {
        get
        {
            static GuaHexagram ChangeYaosAndMakeGua(
                IEnumerable<Yinyang> yinyangs, params int[] yaoIndexes)
            {
                var result = yinyangs.ToArray();
                foreach (var i in yaoIndexes)
                    result[i] = !result[i];
                return new(result);
            }
            var result = this.Gong.Concat(this.Gong);
            return shiying switch
            {
                Shiying.Bachun => ChangeYaosAndMakeGua(result),
                Shiying.Yishi => ChangeYaosAndMakeGua(result, 0),
                Shiying.Ershi => ChangeYaosAndMakeGua(result, 0, 1),
                Shiying.Sanshi => ChangeYaosAndMakeGua(result, 0, 1, 2),
                Shiying.Sishi => ChangeYaosAndMakeGua(result, 0, 1, 2, 3),
                Shiying.Wushi => ChangeYaosAndMakeGua(result, 0, 1, 2, 3, 4),
                Shiying.Youhun => ChangeYaosAndMakeGua(result, 0, 1, 2, 4),
                Shiying.Guihun => ChangeYaosAndMakeGua(result, 4),
                _ => throw new ArgumentException(
                    $"The argument {nameof(shiying)} contains a invalid value {shiying}.", nameof(shiying))
            };
        }
    }

    /// <inheritdoc />
    public int CompareTo(Bagong? other)
    {
        if (other is null)
            return 1;
        return this.Gong.CompareTo(other.Gong);
    }

    /// <inheritdoc />
    public bool Equals(Bagong? other)
    {
        return this.Gong.Equals(other?.Gong);
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        if (obj is not Bagong other)
            return false;
        return this.Gong.Equals(other.Gong);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return this.Gong.GetHashCode();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"Bagong of {this.Gong}";
    }
}
