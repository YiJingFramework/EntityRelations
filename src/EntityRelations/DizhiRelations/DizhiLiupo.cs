using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public sealed class DizhiLiupo : DizhiRelationBase<DizhiLiuhe>
{
    public Dizhi DizhiOfYin { get; }
    public Dizhi DizhiOfYang { get; }

    public Dizhi TheOther { get; }

    public DizhiLiupo(Dizhi theCurrent) : base(theCurrent)
    {
        if (theCurrent.Index is 1 or 3 or 5 or 7 or 9 or 11)
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
