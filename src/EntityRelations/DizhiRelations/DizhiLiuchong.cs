using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支六冲关系。
/// Liuchong relation between Dizhis.
/// </summary>
public sealed class DizhiLiuchong : DizhiRelationBase<DizhiLiuchong>
{
    /// <summary>
    /// 此关系中位于子（含）之后的地支。
    /// The Dizhi after Zi (included) in this relation.
    /// </summary>
    public Dizhi DizhiAfterZi { get; }
    /// <summary>
    /// 此关系中位于午（含）之后的地支。
    /// The Dizhi after Wu (included) in this relation.
    /// </summary>
    public Dizhi DizhiAfterWu { get; }

    /// <inheritdoc />
    protected override Dizhi DeterminantForSameAs => this.DizhiAfterZi;

    /// <summary>
    /// 此关系中的另一个地支。
    /// The other Dizhi in this relation except the current.
    /// </summary>
    public Dizhi TheOther { get; }

    /// <summary>
    /// 创建一个此关系的示例。
    /// Create an instance of this relation.
    /// </summary>
    /// <param name="theCurrent">
    /// 当前的地支。
    /// The current Dizhi.
    /// </param>
    public DizhiLiuchong(Dizhi theCurrent) : base(theCurrent)
    {
        this.TheOther = theCurrent.Next(6);

        if (theCurrent.Index < 7)
        {
            this.DizhiAfterZi = theCurrent;
            this.DizhiAfterWu = this.TheOther;
        }
        else
        {
            this.DizhiAfterZi = this.TheOther;
            this.DizhiAfterWu = theCurrent;
        }
    }
}
