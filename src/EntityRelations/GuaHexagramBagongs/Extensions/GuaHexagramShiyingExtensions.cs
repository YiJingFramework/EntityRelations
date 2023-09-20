namespace YiJingFramework.EntityRelations.GuaHexagramBagongs.Extensions;

/// <summary>
/// 对 <seealso cref="Shiying"/> 的扩展。
/// Extensions of <seealso cref="Shiying"/>.
/// </summary>
public static class GuaHexagramShiyingExtensions
{
    /// <summary>
    /// 取世应对应的世爻的序号。
    /// Get the corresponding Shiyao's index of a Shiying.
    /// </summary>
    /// <param name="shiying">
    /// 世应。
    /// The Shiying.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static int Shiyao(this Shiying shiying)
    {
        var result = (int)shiying;
        result %= 6;
        result += 6;
        return result % 6;
    }

    /// <summary>
    /// 取世应对应的应爻的序号。
    /// Get the corresponding Yingyao's index of a Shiying.
    /// </summary>
    /// <param name="shiying">
    /// 世应。
    /// The Shiying.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static int Yingyao(this Shiying shiying)
    {
        var result = (int)shiying;
        result %= 6;
        result += 6 + 3;
        return result % 6;
    }
}
