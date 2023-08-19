using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganRelations;
/// <summary>
/// 所有天干关系的基类。
/// The base class of all the Tiangan relations.
/// </summary>
/// <typeparam name="TSelf">
/// 类型自身。
/// The type itself.
/// </typeparam>
public abstract class TianganRelationBase<TSelf> :
    IEquatable<TSelf>, IComparable<TSelf>
    where TSelf : TianganRelationBase<TSelf>
{
    /// <summary>
    /// 当前的天干。
    /// The current Tiangan.
    /// </summary>
    public Tiangan TheCurrent { get; }

    /// <summary>
    /// 决定 <seealso cref="SameAs(TSelf?)"/> 结果的干。
    /// The determinant for <seealso cref="SameAs(TSelf?)"/>.
    /// </summary>
    protected abstract Tiangan DeterminantForSameAs { get; }

    private protected TianganRelationBase(Tiangan theCurrent)
    {
        this.TheCurrent = theCurrent;
    }

    /// <summary>
    /// 判断当前实例是否和另一个实例表示相同的关系。
    /// 如甲庚相合，在当前干分别为甲和庚时，
    /// <seealso cref="Equals(TSelf?)"/> 会返回 <c>false</c> ，而 <seealso cref="SameAs(TSelf?)"/> 返回 <c>true</c> 。
    /// Determine whether the current instance represents the same relation as the other.
    /// Taking the Wuhe relation between Jia and Geng as an example,
    /// when the current Tiangans are Jia and Geng respectively,
    /// <seealso cref="Equals(TSelf?)"/> returns <c>false</c> and <seealso cref="SameAs(TSelf?)"/> returns <c>true</c>.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool SameAs(TSelf? other)
    {
        return this.DeterminantForSameAs == other?.DeterminantForSameAs;
    }

    /// <inheritdoc />
    public int CompareTo(TSelf? other)
    {
        if (other is null)
            return 1;
        return this.TheCurrent.CompareTo(other.TheCurrent);
    }

    /// <inheritdoc />
    public bool Equals(TSelf? other)
    {
        return this.TheCurrent.Equals(other?.TheCurrent);
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        if (obj is not TSelf other)
            return false;
        return this.TheCurrent.Equals(other.TheCurrent);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return this.TheCurrent.GetHashCode();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.GetType().Name} of {this.TheCurrent}";
    }
}
