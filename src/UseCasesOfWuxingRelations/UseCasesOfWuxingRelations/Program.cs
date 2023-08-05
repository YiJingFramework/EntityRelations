using YiJingFramework.EntityRelations.EntityStrings.Conversions;
using YiJingFramework.EntityRelations.EntityStrings.Extensions;
using YiJingFramework.EntityRelations.WuxingRelations;
using YiJingFramework.EntityRelations.WuxingRelations.Extensions;
using YiJingFramework.PrimitiveTypes;

var wood = Wuxing.Wood;
var metal = Wuxing.Metal;
var relationship = WuxingRelation.OvercomingMe;

Console.WriteLine(
    $"For {wood}, " +
    $"{metal} is the Wuxing that {wood.GetRelation(metal)}.");

Console.WriteLine(
    $"For {wood}, " +
    $"the Wuxing that {relationship} is {wood.GetWuxing(relationship)}.");

var conversion = WuxingRelationToStringConversions.LiuqinInEnglish;
Console.WriteLine($"{relationship.ToString(conversion)} of {wood} is {metal}.");

Console.WriteLine();
// Outputs:
// For Wood, Metal is the Wuxing that OvercomingMe.
// For Wood, the Wuxing that OvercomingMe is Metal.
// Superior&Spirit of Wood is Metal.
