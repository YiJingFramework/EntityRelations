using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支三会关系。
/// Sanhui relation between Dizhis.
/// </summary>
public sealed class DizhiSanhui : DizhiRelationBase<DizhiSanhui>
{
    /// <summary>
    /// 此关系中属于孟的地支。
    /// The Dizhi in this relation which is the Meng (Meng Zhong Ji).
    /// </summary>
    public Dizhi DizhiOfMeng { get; }
    /// <summary>
    /// 此关系中属于仲的地支。
    /// The Dizhi in this relation which is the Zhong (Meng Zhong Ji).
    /// </summary>
    public Dizhi DizhiOfZhong { get; }
    /// <summary>
    /// 此关系中属于季的地支。
    /// The Dizhi in this relation which is the Ji (Meng Zhong Ji).
    /// </summary>
    public Dizhi DizhiOfJi { get; }

    /// <inheritdoc />
    protected override Dizhi DeterminantForSameAs => this.DizhiOfZhong;

    /// <summary>
    /// 此关系中的其他地支。
    /// The other Dizhis in this relation except the current.
    /// </summary>
    public (Dizhi, Dizhi) TheOthers { get; }

    /// <summary>
    /// 创建一个此关系的实例。
    /// Create an instance of this relation.
    /// </summary>
    /// <param name="theCurrent">
    /// 当前的地支。
    /// The current Dizhi.
    /// </param>
    public DizhiSanhui(Dizhi theCurrent) : base(theCurrent)
    {
        switch (theCurrent.Index)
        {
            case 3 or 6 or 9 or 12:
                this.DizhiOfMeng = theCurrent;
                this.DizhiOfZhong = theCurrent.Next();
                this.DizhiOfJi = theCurrent.Next(2);
                this.TheOthers = (this.DizhiOfZhong, this.DizhiOfJi);
                break;
            case 4 or 7 or 10 or 1:
                this.DizhiOfMeng = theCurrent.Next(-1);
                this.DizhiOfZhong = theCurrent;
                this.DizhiOfJi = theCurrent.Next(1);
                this.TheOthers = (this.DizhiOfMeng, this.DizhiOfJi);
                break;
            default:
                this.DizhiOfMeng = theCurrent.Next(-2);
                this.DizhiOfZhong = theCurrent.Next(-1);
                this.DizhiOfJi = theCurrent;
                this.TheOthers = (this.DizhiOfMeng, this.DizhiOfZhong);
                break;
        }
    }
}
