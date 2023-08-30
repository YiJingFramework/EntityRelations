using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支三合关系。
/// Sanhe relation between Dizhis.
/// </summary>
public sealed class DizhiSanhe : DizhiRelationBase<DizhiSanhe>
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
    /// The Dizhi in this relation after the current.
    /// </summary>
    public Dizhi TheNext { get; }
    /// <summary>
    /// 此关系中的当前地支的上一个地支。
    /// The Dizhi in this relation before the current.
    /// </summary>
    public Dizhi ThePrevious { get; }

    /// <summary>
    /// 创建一个此关系的实例。
    /// Create an instance of this relation.
    /// </summary>
    /// <param name="theCurrent">
    /// 当前的地支。
    /// The current Dizhi.
    /// </param>
    public DizhiSanhe(Dizhi theCurrent) : base(theCurrent)
    {
        this.TheNext = theCurrent.Next(4);
        this.ThePrevious = theCurrent.Next(8);

        switch ((int)theCurrent)
        {
            case 3 or 6 or 9 or 12:
                this.DizhiOfZhangsheng = theCurrent;
                this.DizhiOfDiwang = this.TheNext;
                this.DizhiOfMu = this.ThePrevious;
                break;
            case 4 or 7 or 10 or 1:
                this.DizhiOfZhangsheng = this.ThePrevious;
                this.DizhiOfDiwang = theCurrent;
                this.DizhiOfMu = this.TheNext;
                break;
            default:
                this.DizhiOfZhangsheng = this.TheNext;
                this.DizhiOfDiwang = this.ThePrevious;
                this.DizhiOfMu = theCurrent;
                break;
        }
    }
}
