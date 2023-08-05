using YiJingFramework.EntityRelations.EntityStrings;
using YiJingFramework.EntityRelations.EntityStrings.Conversions;
using YiJingFramework.EntityRelations.EntityStrings.Extensions;
using YiJingFramework.EntityRelations.WuxingRelations;
using YiJingFramework.PrimitiveTypes;

var toShengxiao = DizhiToStringConversions.ShengxiaoInEnglish;
Dizhi chou = Dizhi.Chou;
Console.WriteLine(
    $"If you were born in the year of {chou}, " +
    $"your Shengxiao is the {chou.ToString(toShengxiao)}.");
Console.WriteLine();
// Output: If you were born in the year of Chou, your Shengxiao is the Cow.

var toLiuqin = WuxingRelationToStringConversions.LiuqinInEnglish;
WuxingRelation generatingMe = WuxingRelation.GeneratingMe;
Console.WriteLine($"One that {generatingMe} is my {generatingMe.ToString(toLiuqin)}.");
Console.WriteLine();
// Output: One that GeneratingMe is my Parent.

ConversionToString<object> myConversation = (object x) => $"{x.GetType().Name}[{x}]";
Console.WriteLine("Hello World".ToString(myConversation));
Console.WriteLine();
// Output: String[Hello World]
