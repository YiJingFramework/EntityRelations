using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganRelations;
/// <summary>
/// 天干四冲关系。
/// Sichong relation between Tiangans.
/// </summary>
public sealed class TianganSichong : TianganRelationBase<TianganSichong>
{
    /// <summary>
    /// 此关系中位于甲（含）之后的天干。
    /// The Tiangan after Jia (included) in this relation.
    /// </summary>
    public Tiangan TianganAfterJia { get; }
    /// <summary>
    /// 此关系中位于庚（含）之后的天干。
    /// The Tiangan after Geng (included) in this relation.
    /// </summary>
    public Tiangan TianganAfterGeng { get; }

    /// <inheritdoc />
    protected override Tiangan DeterminantForSameAs => this.TianganAfterJia;

    /// <summary>
    /// 此关系中的另一个天干。
    /// The other Tiangan in this relation except the current.
    /// </summary>
    public Tiangan TheOther { get; }

    /// <summary>
    /// 创建一个此关系的实例。
    /// Create an instance of this relation.
    /// </summary>
    /// <param name="theCurrent">
    /// 当前的天干。
    /// The current Tiangan.
    /// </param>
    /// <exception cref="ArgumentException">
    /// 此天干不被包含在任何一种四冲关系中。
    /// The current Tiangan is not included in any Sichong relation.
    /// </exception>
    public TianganSichong(Tiangan theCurrent) : base(theCurrent)
    {
        if (theCurrent.Index < 5)
        {
            this.TheOther = theCurrent.Next(5 + 1);
            this.TianganAfterJia = theCurrent;
            this.TianganAfterGeng = this.TheOther;
        }
        else if (theCurrent.Index >= 7)
        {
            this.TheOther = theCurrent.Next(-1 - 5);
            this.TianganAfterJia = this.TheOther;
            this.TianganAfterGeng = theCurrent;
        }
        else
        {
            throw new ArgumentException("The current Tiangan is not included in any Sichong relation.");
        }
    }
}
