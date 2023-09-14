using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.DizhiMengZhongJis.Extensions;
/// <summary>
/// 关于地支孟仲季的扩展。
/// Extensions about Dizhis' MengZhongJi.
/// </summary>
public static class DizhiMengZhongJiExtensions
{
    /// <summary>
    /// 获取地支的孟仲季。
    /// Get the Dizhi's MengZhongJi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static MengZhongJi MengZhongJi(this Dizhi dizhi)
    {
        /*
         * | Method | Mean     | Error    | StdDev   |
         * |------- |---------:|---------:|---------:|
         * | Mod    | 79.32 ns | 1.165 ns | 1.090 ns |
         * | Switch | 73.92 ns | 1.523 ns | 1.813 ns |
        */

        return (int)dizhi switch
        {
            2 or 5 or 8 or 11 => DizhiMengZhongJis.MengZhongJi.Meng,
            0 or 3 or 6 or 9 => DizhiMengZhongJis.MengZhongJi.Zhong,
            _ => DizhiMengZhongJis.MengZhongJi.Ji
        };
    }
}
