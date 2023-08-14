using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public sealed class DizhiLiuchong : DizhiRelationBase<DizhiLiuhe>
{
    public Dizhi DizhiAfterZi { get; }
    public Dizhi DizhiAfterWu { get; }

    public Dizhi TheOther { get; }

    public DizhiLiuchong(Dizhi theCurrent) : base(theCurrent)
    {
        this.TheOther = theCurrent.Next(6);

        if (theCurrent.Index < 7)
        {
            this.DizhiAfterZi = theCurrent;
            this.DizhiAfterWu = this.TheOther;
        }
        else
        {
            this.DizhiAfterZi = this.TheOther;
            this.DizhiAfterWu = theCurrent;
        }
    }
}
