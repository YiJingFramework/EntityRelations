using YiJingFramework.EntityRelations.EntityStrings.Conversions;
using YiJingFramework.EntityRelations.EntityStrings.Extensions;
using YiJingFramework.EntityRelations.WuxingRelations;
using YiJingFramework.EntityRelations.WuxingRelations.Extensions;
using YiJingFramework.PrimitiveTypes;

static void WriteTableLine(IEnumerable<string> items)
{
    foreach (var item in items)
    {
        Console.Write("|");
        Console.Write(item);
    }
    Console.WriteLine("|");
}

var wuxings = from i in Enumerable.Range(0, 5)
              select (Wuxing)i;

var relationships = new[]
{
    WuxingRelation.SameAsMe,
    WuxingRelation.GeneratingMe,
    WuxingRelation.GeneratedByMe,
    WuxingRelation.OvercomingMe,
    WuxingRelation.OvercameByMe
};

var inChinese = WuxingRelationToStringConversions.InChinese;

WriteTableLine(wuxings.Select(x => x.ToString("C")).Prepend("关系"));
WriteTableLine(wuxings.Select(x => ":-:").Prepend(":-:"));
foreach (var r in relationships)
    WriteTableLine(wuxings.Select(x => x.GetWuxing(r).ToString("C")).Prepend(r.ToString(inChinese)));

Console.WriteLine();

WriteTableLine(wuxings.Select(x => x.ToString()).Prepend("Relationship"));
WriteTableLine(wuxings.Select(x => ":-:").Prepend(":-:"));
foreach (var r in relationships)
    WriteTableLine(wuxings.Select(x => x.GetWuxing(r).ToString()).Prepend(r.ToString()));

