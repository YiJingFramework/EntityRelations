using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public sealed class DizhiSanhe : DizhiRelationBase<DizhiLiuhe>
{
    public Dizhi DizhiOfZhangsheng { get; }
    public Dizhi DizhiOfDiwang { get; }
    public Dizhi DizhiOfMu { get; }

    public Dizhi TheNext { get; }
    public Dizhi TheLast { get; }

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
