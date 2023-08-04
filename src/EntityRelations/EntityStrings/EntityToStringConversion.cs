using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiJingFramework.EntityRelations.EntityStrings;

/// <summary>
/// 表示一个从 <typeparamref name="T"/> 到字符串的转换。
/// Represents a conversion from <typeparamref name="T"/>s to strings. 
/// </summary>
/// <typeparam name="T">
/// 待转换的类型。
/// Type of the values.
/// </typeparam>
/// <param name="value">
/// 要转换的值。
/// The value to convert.
/// </param>
/// <returns>
/// 结果。
/// The result.
/// </returns>
public delegate string ConversionToString<T>(T value);
