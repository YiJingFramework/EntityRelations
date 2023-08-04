using YiJingFramework.EntityRelations.EntityToString.Conversions;
using YiJingFramework.EntityRelations.WuxingRelationship.Extensions;
using YiJingFramework.PrimitiveTypes;

var wood = Wuxing.Wood;
var metal = Wuxing.Metal;
var relationship = RelationOfWuxing.OvercomingMe;

Console.WriteLine(
    $"For {wood}, " +
    $"{metal} is the Wuxing that {wood.GetWuxingRelationship(metal)}.");

Console.WriteLine(
    $"For {wood}, " +
    $"the Wuxing that {relationship} is {wood.GetWuxingThat(relationship)}.");

var conversion = WuxingRelationToStringConversions.LiuqinInEnglish;
Console.WriteLine($"{relationship.ToString(conversion)} of {wood} is {metal}.");

Console.WriteLine();
// Outputs:
// For Wood, Metal is the Wuxing that OvercomingMe.
// For Wood, the Wuxing that OvercomingMe is Metal.
// Superior&Spirit of Wood is Metal.