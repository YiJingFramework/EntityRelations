using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支三合关系。
/// Sanhe relation between Dizhis.
/// </summary>
public sealed class DizhiSanhe : DizhiRelationBase<DizhiLiuhe>
{
    /// <summary>
    /// 此关系中属于长生的地支。
    /// The Dizhi in this relation which is the Zhangsheng (Twelve Zhangshengs).
    /// </summary>
    public Dizhi DizhiOfZhangsheng { get; }
    /// <summary>
    /// 此关系中属于帝旺的地支。
    /// The Dizhi in this relation which is the Diwang (Twelve Zhangshengs).
    /// </summary>
    public Dizhi DizhiOfDiwang { get; }
    /// <summary>
    /// 此关系中属于墓的地支。
    /// The Dizhi in this relation which is the Mu (Twelve Zhangshengs).
    /// </summary>
    public Dizhi DizhiOfMu { get; }

    /// <inheritdoc />
    protected override Dizhi DeterminantForSameAs => this.DizhiOfDiwang;

    /// <summary>
    /// 此关系中的当前地支的下一个地支。
    /// The Dizhi in this relation next to the current.
    /// </summary>
    public Dizhi TheNext { get; }
    /// <summary>
    /// 此关系中除了当前地支和 <seealso cref="TheNext"/> 外剩下的地支。
    /// The remaining Dizhi in this relation besides the current and <seealso cref="TheNext"/>.
    /// </summary>
    public Dizhi TheLast { get; }

    /// <summary>
    /// 创建一个此关系的示例。
    /// Create an instance of this relation.
    /// </summary>
    /// <param name="theCurrent">
    /// 当前的地支。
    /// The current Dizhi.
    /// </param>
    public DizhiSanhe(Dizhi theCurrent) : base(theCurrent)
    {
        this.TheNext = theCurrent.Next(4);
        this.TheLast = theCurrent.Next(8);

        switch (theCurrent.Index)
        {
            case 3 or 6 or 9 or 12:
                this.DizhiOfZhangsheng = theCurrent;
                this.DizhiOfDiwang = this.TheNext;
                this.DizhiOfMu = this.TheLast;
                break;
            case 4 or 7 or 10 or 1:
                this.DizhiOfZhangsheng = this.TheLast;
                this.DizhiOfDiwang = theCurrent;
                this.DizhiOfMu = this.TheNext;
                break;
            default:
                this.DizhiOfZhangsheng = this.TheNext;
                this.DizhiOfDiwang = this.TheLast;
                this.DizhiOfMu = theCurrent;
                break;
        }
    }
}
