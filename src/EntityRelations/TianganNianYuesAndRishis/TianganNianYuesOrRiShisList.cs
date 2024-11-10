using System.Collections;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis;

/// <summary>
/// 年中各月或日中各时。
/// Yues in a Nian, or Shis in a Nian.
/// </summary>
/// <param name="firstTiangan">
/// 首个天干。
/// The first Tiangan.
/// </param>
/// <param name="firstDizhi">
/// 首个地支。
/// The first Dizhi.
/// </param>
public abstract class TianganNianYuesOrRiShisList<TSelf>(Tiangan firstTiangan, Dizhi firstDizhi) : 
    IReadOnlyList<Ganzhi>
    where TSelf : TianganNianYuesOrRiShisList<TSelf>
{
    private readonly Ganzhi firstGanzhi = Ganzhi.FromGanzhi(firstTiangan, firstDizhi);

    /// <summary>
    /// 获取月或时。
    /// Get a Yue or Shi.
    /// </summary>
    /// <param name="index">
    /// 月或时的地支。
    /// Dizhi of the Yue or Shi.
    /// </param>
    /// <returns>
    /// 月或时。
    /// Yue or Shi.
    /// </returns>
    public Ganzhi this[Dizhi index]
    {
        get
        {
            return this[index - firstDizhi];
        }
    }

    /// <summary>
    /// 获取月或时。
    /// Get a Yue or Shi.
    /// </summary>
    /// <param name="index">
    /// 从零开始的月或时序数。
    /// Zero-based index of the Yue or Shi.
    /// </param>
    /// <returns>
    /// 月或时。
    /// Yue or Shi.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="index"/> is less than zero (inclusive) or greater than twelve (exclusive).
    /// </exception>
    public Ganzhi this[int index]
    {
        get
        {
            if (index >= 12 || index < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(index), 
                    $"{nameof(index)} is less than zero (inclusive) or greater than twelve (exclusive).");
            return this.firstGanzhi.Next(index);
        }
    }

    /// <summary>
    /// 月或时的数量。
    /// 总为 <c>12</c> 。
    /// Count of Yues or Shis.
    /// This value will always be <c>12</c>.
    /// </summary>
    public int Count => 12;

    /// <inheritdoc />
    public IEnumerator<Ganzhi> GetEnumerator()
    {
        static IEnumerable<Ganzhi> AsEnumerable(Ganzhi first)
        {
            for (int i = 0; i < 12; i++)
            {
                yield return first;
                first = first.Next();
            }
        }

        return AsEnumerable(this.firstGanzhi).GetEnumerator();
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
