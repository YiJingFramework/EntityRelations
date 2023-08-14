using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public abstract class DizhiRelationBase<TSelf> :
    IEquatable<TSelf>, IComparable<TSelf>
    where TSelf : DizhiRelationBase<TSelf>
{
    public Dizhi TheCurrent { get; }

    private protected DizhiRelationBase(Dizhi theCurrent)
    {
        this.TheCurrent = theCurrent;
    }

    /// <inheritdoc />
    public int CompareTo(TSelf? other)
    {
        if(other is null)
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
