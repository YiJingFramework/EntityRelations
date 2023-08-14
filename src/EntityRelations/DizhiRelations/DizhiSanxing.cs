using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public sealed class DizhiSanxing : DizhiRelationBase<DizhiLiuhe>
{
    public Dizhi ThePrevious { get; }
    public Dizhi TheNext { get; }
    public IReadOnlyList<Dizhi> Dizhis { get; }

    public DizhiSanxing(Dizhi theCurrent) : base(theCurrent)
    {
        switch (theCurrent.Index)
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
