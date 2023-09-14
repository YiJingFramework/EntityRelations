using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支六合关系。
/// Liuhe relation between Dizhis.
/// </summary>
public sealed class DizhiLiuhe : DizhiRelationBase<DizhiLiuhe>
{
    /// <summary>
    /// 此关系中位于丑（含）之后的地支。
    /// The Dizhi after Chou (included) in this relation.
    /// </summary>
    public Dizhi DizhiAfterChou { get; }
    /// <summary>
    /// 此关系中位于未（含）之后的地支。
    /// The Dizhi after Wei (included) in this relation.
    /// </summary>
    public Dizhi DizhiAfterWei { get; }

    /// <inheritdoc />
    protected override Dizhi DeterminantForSameAs => this.DizhiAfterChou;

    /// <summary>
    /// 此关系中的另一个地支。
    /// The other Dizhi in this relation except the current.
    /// </summary>
    public Dizhi TheOther { get; }

    /// <summary>
    /// 创建一个此关系的实例。
    /// Create an instance of this relation.
    /// </summary>
    /// <param name="theCurrent">
    /// 当前的地支。
    /// The current Dizhi.
    /// </param>
    public DizhiLiuhe(Dizhi theCurrent) : base(theCurrent)
    {
        this.TheOther = (Dizhi)(0 - ((int)theCurrent - 1));

        if ((int)theCurrent is >= 1 and < 7)
        {
            this.DizhiAfterChou = theCurrent;
            this.DizhiAfterWei = this.TheOther;
        }
        else
        {
            this.DizhiAfterChou = this.TheOther;
            this.DizhiAfterWei = theCurrent;
        }
    }
}
