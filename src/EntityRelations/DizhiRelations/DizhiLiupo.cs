using YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支六破关系。
/// Liupo relation between Dizhis.
/// </summary>
public sealed class DizhiLiupo : DizhiRelationBase<DizhiLiupo>
{
    /// <summary>
    /// 此关系中属阴的地支。
    /// 此阴阳的区分方式和 <seealso cref="TianganDizhiYinyangExtensions.Yinyang(Dizhi)"/> 一致。
    /// The Dizhi in this relation whose characteristic is Yin.
    /// The Yinyang is decided in the same way as <seealso cref="TianganDizhiYinyangExtensions.Yinyang(Dizhi)"/>.
    /// </summary>
    public Dizhi DizhiOfYin { get; }
    /// <summary>
    /// 此关系中属阳的地支。
    /// 此阴阳的区分方式和 <seealso cref="TianganDizhiYinyangExtensions.Yinyang(Dizhi)"/> 一致。
    /// The Dizhi in this relation whose characteristic is Yang.
    /// The Yinyang is decided in the same way as <seealso cref="TianganDizhiYinyangExtensions.Yinyang(Dizhi)"/>.
    /// </summary>
    public Dizhi DizhiOfYang { get; }

    /// <inheritdoc />
    protected override Dizhi DeterminantForSameAs => this.DizhiOfYang;

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
    public DizhiLiupo(Dizhi theCurrent) : base(theCurrent)
    {
        if ((int)theCurrent is 1 or 3 or 5 or 7 or 9 or 11)
        {
            this.TheOther = theCurrent.Next(-3);
            this.DizhiOfYin = this.TheOther;
            this.DizhiOfYang = theCurrent;
        }
        else
        {
            this.TheOther = theCurrent.Next(3);
            this.DizhiOfYin = theCurrent;
            this.DizhiOfYang = this.TheOther;
        }
    }
}
