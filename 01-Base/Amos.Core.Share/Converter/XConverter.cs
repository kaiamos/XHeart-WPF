using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Amos.Core.Converter
{
    /// <summary>
    /// 此类是用来获取转换器的类，Lazy 加载是保证在第一次使用的时候才加载
    /// </summary>
    public sealed class XConverter
    {
        /// <summary>
        ///  Boolean 类型和 Visibility 类型互转转换器
        /// </summary>
        public static BooleanToVisibilityConverter BooleanToVisibilityConverter { get; } = new Lazy<BooleanToVisibilityConverter>().Value;


        public static FalseToVisibilityConverter FalseToVisibilityConverter { get; } = new Lazy<FalseToVisibilityConverter>().Value;

    }

}
