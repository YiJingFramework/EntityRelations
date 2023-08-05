using System.Diagnostics.Metrics;
using YiJingFramework.EntityRelations.EntityCharacteristics.Extensions;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

var qian = GuaTrigram.Parse("111");
Console.WriteLine(qian.Yinyang());
Console.WriteLine(qian.Wuxing());
Console.WriteLine();
// Ouputs:
// Yang
// Metal

var zi = Dizhi.Zi;
Console.WriteLine(zi.Yinyang());
Console.WriteLine(zi.Wuxing());
Console.WriteLine();
// Ouputs:
// Yang
// Water

var jia = Tiangan.Yi;
Console.WriteLine(jia.Yinyang());
Console.WriteLine(jia.Wuxing());
Console.WriteLine();
// Ouputs:
// Yin
// Wood
