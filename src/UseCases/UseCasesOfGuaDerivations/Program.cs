using YiJingFramework.EntityRelations.GuaDerivations.Extensions;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

Console.WriteLine(Gua.Parse("111111").ChangeLines(1, 2, 3, 2));
Console.WriteLine();
// Output: 101011

Console.WriteLine(Gua.Parse("10100000").Cuogua());
Console.WriteLine();
// Output: 01011111

Console.WriteLine(Gua.Parse("11110101").Zonggua());
Console.WriteLine();
// Output: 10101111

Console.WriteLine(GuaHexagram.Parse("111000").Hugua());
Console.WriteLine();
// Output: 110100

Console.WriteLine(GuaHexagram.Parse("100110").Jiaogua());
Console.WriteLine();
// Output: 110100

Console.WriteLine(Gua.Parse("10011011").Split(3).ElementAt(0));
Console.WriteLine(Gua.Parse("10011011").Split(3).ElementAt(1));
Console.WriteLine(Gua.Parse("10011011").Split(3).ElementAt(2));
Console.WriteLine();
// Outputs:
// 100
// 110
// 11
