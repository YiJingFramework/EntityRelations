using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public sealed class DizhiLiuhai : DizhiRelationBase<DizhiLiuhe>
{
    public Dizhi DizhiAfterChen { get; }
    public Dizhi DizhiAfterXu { get; }

    public Dizhi TheOther { get; }

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
