using YiJingFramework.EntityRelations.WuxingRelationshipExtensions;
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
    WuxingRelationship.SameAsMe,
    WuxingRelationship.GeneratingMe,
    WuxingRelationship.GeneratedByMe,
    WuxingRelationship.OvercomingMe,
    WuxingRelationship.OvercameByMe
};

var inChinese = WuxingRelationshipToStringConversions.InChinese;

WriteTableLine(wuxings.Select(x => x.ToString("C")).Prepend("关系"));
WriteTableLine(wuxings.Select(x => ":-:").Prepend(":-:"));
foreach (var r in relationships)
    WriteTableLine(wuxings.Select(x => x.GetWuxingThat(r).ToString("C")).Prepend(r.ToString(inChinese)));

Console.WriteLine();

WriteTableLine(wuxings.Select(x => x.ToString()).Prepend("Relationship"));
WriteTableLine(wuxings.Select(x => ":-:").Prepend(":-:"));
foreach (var r in relationships)
    WriteTableLine(wuxings.Select(x => x.GetWuxingThat(r).ToString()).Prepend(r.ToString()));

