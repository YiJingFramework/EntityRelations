using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支六害（穿）关系。
/// Liuhai (Liuchuan) relation between Dizhis.
/// </summary>
public sealed class DizhiLiuhai : DizhiRelationBase<DizhiLiuhai>
{
    /// <summary>
    /// 此关系中位于辰（含）之后的地支。
    /// The Dizhi after Chen (included) in this relation.
    /// </summary>
    public Dizhi DizhiAfterChen { get; }
    /// <summary>
    /// 此关系中位于戌（含）之后的地支。
    /// The Dizhi after Xu (included) in this relation.
    /// </summary>
    public Dizhi DizhiAfterXu { get; }

    /// <inheritdoc />
    protected override Dizhi DeterminantForSameAs => this.DizhiAfterChen;

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
    public DizhiLiuhai(Dizhi theCurrent) : base(theCurrent)
    {
        this.TheOther = new(4 - (theCurrent.Index - 5));

        if (theCurrent.Index is >= 5 and < 11)
        {
            this.DizhiAfterChen = theCurrent;
            this.DizhiAfterXu = this.TheOther;
        }
        else
        {
            this.DizhiAfterChen = this.TheOther;
            this.DizhiAfterXu = theCurrent;
        }
    }
}
