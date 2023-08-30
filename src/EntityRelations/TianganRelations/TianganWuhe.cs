using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.TianganRelations;
/// <summary>
/// 天干五合关系。
/// Wuhe relation between Tiangans.
/// </summary>
public sealed class TianganWuhe : TianganRelationBase<TianganWuhe>
{
    /// <summary>
    /// 此关系中位于甲（含）之后的天干。
    /// The Tiangan after Jia (included) in this relation.
    /// </summary>
    public Tiangan TianganAfterJia { get; }
    /// <summary>
    /// 此关系中位于己（含）之后的天干。
    /// The Tiangan after Ji (included) in this relation.
    /// </summary>
    public Tiangan TianganAfterJi { get; }

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
    public TianganWuhe(Tiangan theCurrent) : base(theCurrent)
    {
        this.TheOther = theCurrent.Next(5);

        if ((int)theCurrent < 6)
        {
            this.TianganAfterJia = theCurrent;
            this.TianganAfterJi = this.TheOther;
        }
        else
        {
            this.TianganAfterJia = this.TheOther;
            this.TianganAfterJi = theCurrent;
        }
    }
}
