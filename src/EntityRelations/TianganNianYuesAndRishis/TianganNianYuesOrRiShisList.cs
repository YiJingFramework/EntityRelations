using System.Collections;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GanzhiCombinations;

namespace YiJingFramework.EntityRelations.TianganNianYuesAndRishis;

/// <summary>
/// 年中各月或日中各时。
/// Yues in a Nian, or Shis in a Nian.
/// </summary>
/// <param name="first">
/// 首个天干。
/// The first Tiangan.
/// </param>
public abstract class TianganNianYuesOrRiShisList<TSelf>(Tiangan first) : 
    IReadOnlyList<Ganzhi>
    where TSelf : TianganNianYuesOrRiShisList<TSelf>
{
    private readonly Ganzhi first = Ganzhi.FromGanzhi(first, Dizhi.Zi);

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
            return this[(int)index];
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
    public Ganzhi this[int index]
    {
        get
        {
            return this.first.Next(index);
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

        return AsEnumerable(this.first).GetEnumerator();
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
