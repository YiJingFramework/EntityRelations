using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelations.EntityStrings.Extensions;

/// <summary>
/// 关于从实体到字符串的转换扩展。
/// Extensions about conversion from Dizhis to strings.
/// </summary>
public static class EntityToStringExtensions
{
    /// <summary>
    /// 将实体通过指定的转换方法转换为字符串。
    /// Convert an entity to string with the given conversion method.
    /// </summary>
    /// <typeparam name="T">
    /// 实体的类型。
    /// Type of the entity.
    /// </typeparam>
    /// <param name="entity">
    /// 要转换的实体。
    /// The entity to convert.
    /// </param>
    /// <param name="conversion">
    /// 要用的转换器。
    /// The converter to be used.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="conversion"/> 为 <c>null</c> 。
    /// <paramref name="conversion"/> is <c>null</c>.
    /// </exception>
    public static string ToString<T>(
        this T entity,
        ConversionToString<T> conversion)
    {
        ArgumentNullException.ThrowIfNull(conversion);
        return conversion(entity);
    }
}
