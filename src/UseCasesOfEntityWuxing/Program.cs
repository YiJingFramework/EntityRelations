using YiJingFramework.EntityRelations.EntityWuxingExtensions;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

var qian = GuaTrigram.Parse("111");
Console.WriteLine(qian.Wuxing());
Console.WriteLine();
// Ouput: Metal

var zi = Dizhi.Zi;
Console.WriteLine(zi.Wuxing());
Console.WriteLine();
// Ouput: Water

var jia = Tiangan.Jia;
Console.WriteLine(jia.Wuxing());
Console.WriteLine();
// Ouput: Wood
