using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 所有地支关系的基类。
/// The base class of all the Dizhi relations.
/// </summary>
/// <typeparam name="TSelf">
/// 类型自身。
/// The type itself.
/// </typeparam>
public abstract class DizhiRelationBase<TSelf> :
    IEquatable<TSelf>, IComparable<TSelf>
    where TSelf : DizhiRelationBase<TSelf>
{
    /// <summary>
    /// 当前支。
    /// The current Dizhi.
    /// </summary>
    public Dizhi TheCurrent { get; }

    /// <summary>
    /// 决定 <seealso cref="SameAs(TSelf?)"/> 结果的支。
    /// The determinant for <seealso cref="SameAs(TSelf?)"/>.
    /// </summary>
    protected abstract Dizhi DeterminantForSameAs { get; }

    private protected DizhiRelationBase(Dizhi theCurrent)
    {
        this.TheCurrent = theCurrent;
    }

    /// <summary>
    /// 判断当前实例是否和另一个实例表示相同的关系。
    /// 如子午相冲，在当前支分别为子和午时，
    /// <seealso cref="Equals(TSelf?)"/> 会返回 <c>false</c> ，而 <seealso cref="SameAs(TSelf?)"/> 返回 <c>true</c> 。
    /// Determine whether the current instance represents the same relation as the other.
    /// Taking the Liuchong relation between Zi and Wu as an example,
    /// when the current Dizhis are Zi and Wu respectively,
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
