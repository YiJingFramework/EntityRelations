using System.Collections.Immutable;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelations.GuaDerivations.Extensions;

/// <summary>
/// 关于卦变换的扩展。
/// Extensions about Guas' derivation.
/// </summary>
public static class GuaDerivationExtensions
{
    #region ChangeYaos
    /// <summary>
    /// 改变卦中几爻，返回修改后的卦。
    /// Change some Yao-s in a Gua and returns the modified Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="yaoIndexes">
    /// 要修改的爻。
    /// 如果出现两次，将会再转回原样。
    /// The Yao-s to be changed.
    /// If a number appears twice, this Yao will be changed back.
    /// </param>
    /// <param name="throwIfOutOfRange">
    /// 指示是否要在超出范围时抛出异常。
    /// 若否，则会忽略超出范围的索引，并继续下一个。
    /// Indicate whether exceptions should be thrown when it is out of range.
    /// If false, the out-of-range indexes will be ignored and will continue to the next ones.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 或 <paramref name="yaoIndexes"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> or <paramref name="yaoIndexes"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// 若 <paramref name="throwIfOutOfRange"/> 为 <c>true</c> ，
    /// 则在索引超出范围时会抛出此异常。
    /// If <paramref name="throwIfOutOfRange"/> is set to <c>true</c>, 
    /// this exception will occurs when one of the indexes is out of range.
    /// </exception>
    public static Gua ChangeYaos(
        this Gua gua, IEnumerable<int> yaoIndexes,
        bool throwIfOutOfRange = true)
    {
        ArgumentNullException.ThrowIfNull(gua);
        ArgumentNullException.ThrowIfNull(yaoIndexes);

        var result = ImmutableArray.CreateBuilder<Yinyang>(gua.Count);
        result.AddRange(gua);
        foreach (var i in yaoIndexes)
        {
            if (i < 0 || i >= result.Count)
            {
                if (throwIfOutOfRange)
                    throw new ArgumentOutOfRangeException(nameof(yaoIndexes));

                continue;
            }

            result[i] = !result[i];
        }
        return new(result.MoveToImmutable());
    }

    /// <typeparam name="TGua">
    /// 卦的类型。
    /// Type of Gua.
    /// </typeparam>
    /// <inheritdoc cref="ChangeYaos(Gua, IEnumerable{int}, bool)"/>
    public static TGua ChangeYaos<TGua>(
        this TGua gua, IEnumerable<int> yaoIndexes,
        bool throwIfOutOfRange = true)
        where TGua : notnull, IGuaWithFixedCount<TGua>
    {
        return (gua?.AsGua())!.ChangeYaos(yaoIndexes, throwIfOutOfRange).AsFixed<TGua>();
    }

    /// <exception cref="ArgumentOutOfRangeException">
    /// 索引超出范围。
    /// One of the indexes is out of range.
    /// </exception>
    /// <inheritdoc cref="ChangeYaos(Gua, IEnumerable{int}, bool)"/>
    public static Gua ChangeYaos(this Gua gua, params int[] yaoIndexes)
    {
        return gua.ChangeYaos(yaoIndexes, true);
    }

    /// <typeparam name="TGua">
    /// 卦的类型。
    /// Type of Gua.
    /// </typeparam>
    /// <inheritdoc cref="ChangeYaos(Gua, int[])"/>
    public static TGua ChangeYaos<TGua>(this TGua gua, params int[] yaoIndexes)
        where TGua : notnull, IGuaWithFixedCount<TGua>
    {
        return (gua?.AsGua())!.ChangeYaos(yaoIndexes, true).AsFixed<TGua>();
    }
    #endregion

    #region Cuogua
    /// <summary>
    /// 获取错卦（改变所有的爻）。
    /// Get a Gua's Cuogua (change all the Yao-s).
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 错卦。
    /// Cuogua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Gua Cuogua(this Gua gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return new Gua(gua.Select(yao => !yao));
    }

    /// <typeparam name="TGua">
    /// 卦的类型。
    /// Type of Gua.
    /// </typeparam>
    /// <inheritdoc cref="Cuogua(Gua)" />
    public static TGua Cuogua<TGua>(this TGua gua)
        where TGua : notnull, IGuaWithFixedCount<TGua>
    {
        return (gua?.AsGua())!.Cuogua().AsFixed<TGua>();
    }
    #endregion

    #region Zonggua
    /// <summary>
    /// 获取综卦（翻转爻的顺序）。
    /// Get a Gua's Zonggua (reverse the order of the Yaos).
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 综卦。
    /// Zonggua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Gua Zonggua(this Gua gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        static IEnumerable<Yinyang> ReverseOrder(Gua gua)
        {
            for (int i = gua.Count - 1; i >= 0; i--)
                yield return gua[i];
        }
        return new Gua(ReverseOrder(gua));
    }

    /// <typeparam name="TGua">
    /// 卦的类型。
    /// Type of Gua.
    /// </typeparam>
    /// <inheritdoc cref="Zonggua(Gua)" />
    public static TGua Zonggua<TGua>(this TGua gua)
        where TGua : notnull, IGuaWithFixedCount<TGua>
    {
        return (gua?.AsGua())!.Zonggua().AsFixed<TGua>();
    }
    #endregion

    #region Hugua
    /// <summary>
    /// 获取互卦（由第二（ <c>[1]</c> ）三四爻和三四五爻组成新的卦）。
    /// Get a Gua's Hugua.
    /// (The Huguas will made up with -- 
    /// the 2nd (<c>[1]</c>) Yao, the 3rd Yao, the 4th Yao,
    /// then the 3rd Yao again, the 4th Yao and the 5th Yao
    /// -- of the original hexagram.)
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 互卦。
    /// Hugua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static GuaHexagram Hugua(this GuaHexagram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return new(gua[1], gua[2], gua[3], gua[2], gua[3], gua[4]);
    }
    #endregion

    #region Jiaogua
    /// <summary>
    /// 获取交卦（交换上下的八卦）。
    /// Get a Gua's Jiaogua (swap the upper GuaTrigram and the lower GuaTrigram).
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 交卦。
    /// Jiaogua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static GuaHexagram Jiaogua(this GuaHexagram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return new(gua[3], gua[4], gua[5], gua[0], gua[1], gua[2]);
    }
    #endregion

    #region Split
    /// <summary>
    /// 拆分一个卦为更小的多个卦。
    /// Split a Gua to smaller Guas.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="pieceLength">
    /// 拆开后每一卦的爻数。
    /// 如果除不尽，则最后一卦可能爻数不一致。
    /// The Yao count of each smaller Guas.
    /// If it cannot be completely divided, the last one may not be this value.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="pieceLength"/> 不大于 <c>0</c> 。
    /// <paramref name="pieceLength"/> is not greater than <c>0</c>.
    /// </exception>
    public static IEnumerable<Gua> Split(this Gua gua, int pieceLength)
    {
        ArgumentNullException.ThrowIfNull(gua);

        if (pieceLength <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(pieceLength),
                $"{nameof(pieceLength)} should be greater than zero.");

        Yinyang[] currentGua = new Yinyang[pieceLength];
        int iCurrentGua = 0;

        for (int iOriginalGua = 0; iOriginalGua < gua.Count; iOriginalGua++)
        {
            currentGua[iCurrentGua] = gua[iOriginalGua];

            iCurrentGua++;
            if (iCurrentGua == pieceLength)
            {
                yield return new(currentGua);
                iCurrentGua = 0;
            }
        }

        if (iCurrentGua is not 0)
        {
            yield return new(currentGua.Take(iCurrentGua));
        }
    }

    /// <summary>
    /// 拆分一个卦为更小的多个卦。
    /// Split a Gua to smaller Guas.
    /// </summary>
    /// <typeparam name="TGuaOut">
    /// 拆开后卦的类型。
    /// Type of the result Guas.
    /// </typeparam>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="theRest">
    /// 余下的部分。
    /// The result part.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// <typeparamref name="TGuaOut"/> 期望的爻数不大于 <c>0</c> 。
    /// <typeparamref name="TGuaOut"/>'s expected count is not greater than <c>0</c>.
    /// </exception>
    public static IEnumerable<TGuaOut> Split<TGuaOut>(this Gua gua, out Gua theRest)
        where TGuaOut : notnull, IGuaWithFixedCount<TGuaOut>
    {
        ArgumentNullException.ThrowIfNull(gua);

        var expectedCount = TGuaOut.ExpectedCount;
        if (TGuaOut.ExpectedCount <= 0)
            throw new InvalidOperationException(
                $"{nameof(TGuaOut)}.{nameof(TGuaOut.ExpectedCount)} should be greater than zero.");

        var result = gua.Split(TGuaOut.ExpectedCount).ToArray();
        if (gua.Count % expectedCount is 0)
        {
            theRest = new Gua();
            return result.Select(x => x.AsFixed<TGuaOut>());
        }
        else
        {
            theRest = result[^1];
            return result.SkipLast(1).Select(x => x.AsFixed<TGuaOut>());
        }
    }
    #endregion
}
