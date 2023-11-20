using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

byte[] hexagramTable = [
    127, 64, 81, 98, 87, 122,
    66, 80, 119, 123, 71, 120,
    125, 111, 68, 72, 89, 102,
    67, 112, 105, 101, 96, 65,
    121, 103, 97, 94, 82, 109,
    92, 78, 124, 79, 104, 69,
    117, 107, 84, 74, 99, 113,
    95, 126, 88, 70, 90, 86,
    93, 110, 73, 100, 116,
    75, 77, 108, 118, 91,
    114, 83, 115, 76, 85, 106 ];

char ToUnicodeChar(GuaHexagram gua)
{
    ArgumentNullException.ThrowIfNull(gua);

    int value = '\u4DC0';
    return (char)(value + Array.IndexOf(hexagramTable, gua.AsGua().ToBytes()[0]));
}

for (int i = 0; i <= 0b111111; i++)
{
    var gua = GuaHexagram.Parse(Convert.ToString(i, 2).PadLeft(6, '0'));
    var c = ToUnicodeChar(gua);
    string p = "\\u" + ((int)c).ToString("x4");
    Console.WriteLine($"{gua.AsGua().ToBytes()[0]} => '{p}',");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

for (int diff = 0; diff <= 0b111111; diff++)
{
    var gua = Gua.FromBytes(hexagramTable[diff]);
    var s = gua.Select(line => line.IsYang ? "yang" : "yin");
    var ss = string.Join(", ", s);
    Console.WriteLine($"{diff} => new GuaHexagram({ss}),");
}
