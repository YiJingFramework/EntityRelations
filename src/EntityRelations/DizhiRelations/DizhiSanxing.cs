using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
/// <summary>
/// 地支三刑关系。
/// Sanxing relation between Dizhis.
/// </summary>
public sealed class DizhiSanxing : DizhiRelationBase<DizhiSanxing>
{
    /// <summary>
    /// 此关系中的地支。
    /// 可能的值为子卯、丑戌未、寅巳申、辰、午、酉、亥。
    /// The Dizhis in this relation.
    /// The possible values are [Zi, Mao], [Chou, Xu, Wei], [Yin, Si, Shen], [Chen], [Wu], [You] and [Hai].
    /// </summary>
    public IReadOnlyList<Dizhi> Dizhis { get; }

    /// <inheritdoc />
    protected override Dizhi DeterminantForSameAs => this.Dizhis[0];

    /// <summary>
    /// 被当前地支刑的地支。
    /// The Dizhi that be Xinged the current.
    /// </summary>
    public Dizhi TheNext { get; }
    /// <summary>
    /// 刑当前地支的地支。
    /// The Dizhi that Xings the current.
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
    public DizhiSanxing(Dizhi theCurrent) : base(theCurrent)
    {
        switch ((int)theCurrent)
        {
            case 1:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Zi, Dizhi.Mao });
                this.TheNext = Dizhi.Mao;
                this.ThePrevious = Dizhi.Mao;
                break;
            case 2:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Chou, Dizhi.Xu, Dizhi.Wei });
                this.TheNext = Dizhi.Xu;
                this.ThePrevious = Dizhi.Wei;
                break;
            case 3:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Yin, Dizhi.Si, Dizhi.Shen });
                this.TheNext = Dizhi.Si;
                this.ThePrevious = Dizhi.Shen;
                break;
            case 4:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Zi, Dizhi.Mao });
                this.TheNext = Dizhi.Zi;
                this.ThePrevious = Dizhi.Zi;
                break;
            case 5:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Chen });
                this.TheNext = Dizhi.Chen;
                this.ThePrevious = Dizhi.Chen;
                break;
            case 6:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Yin, Dizhi.Si, Dizhi.Shen });
                this.TheNext = Dizhi.Shen;
                this.ThePrevious = Dizhi.Yin;
                break;
            case 7:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Wu });
                this.TheNext = Dizhi.Wu;
                this.ThePrevious = Dizhi.Wu;
                break;
            case 8:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Chou, Dizhi.Xu, Dizhi.Wei });
                this.TheNext = Dizhi.Chou;
                this.ThePrevious = Dizhi.Xu;
                break;
            case 9:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Yin, Dizhi.Si, Dizhi.Shen });
                this.TheNext = Dizhi.Yin;
                this.ThePrevious = Dizhi.Si;
                break;
            case 10:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.You });
                this.TheNext = Dizhi.You;
                this.ThePrevious = Dizhi.You;
                break;
            case 11:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Chou, Dizhi.Xu, Dizhi.Wei });
                this.TheNext = Dizhi.Wei;
                this.ThePrevious = Dizhi.Chou;
                break;
            default:
                this.Dizhis = Array.AsReadOnly(new[] { Dizhi.Hai });
                this.TheNext = Dizhi.Hai;
                this.ThePrevious = Dizhi.Hai;
                break;
        }
    }
}
