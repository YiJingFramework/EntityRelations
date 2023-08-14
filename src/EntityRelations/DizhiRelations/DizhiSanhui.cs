using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public sealed class DizhiSanhui : DizhiRelationBase<DizhiLiuhe>
{
    public Dizhi DizhiOfMeng { get; }
    public Dizhi DizhiOfZhong { get; }
    public Dizhi DizhiOfJi { get; }

    public (Dizhi, Dizhi) TheOthers { get; }

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
