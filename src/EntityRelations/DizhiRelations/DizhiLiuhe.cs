using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiRelations;
public sealed class DizhiLiuhe : DizhiRelationBase<DizhiLiuhe>
{
    public Dizhi DizhiAfterChou { get; }
    public Dizhi DizhiAfterWei { get; }

    public Dizhi TheOther { get; }

    public DizhiLiuhe(Dizhi theCurrent) : base(theCurrent)
    {
        this.TheOther = new(1 - (theCurrent.Index - 2));

        if (theCurrent.Index is >= 2 and < 8)
        {
            this.DizhiAfterChou = theCurrent;
            this.DizhiAfterWei = this.TheOther;
        }
        else
        {
            this.DizhiAfterChou = this.TheOther;
            this.DizhiAfterWei = theCurrent;
        }
    }
}
