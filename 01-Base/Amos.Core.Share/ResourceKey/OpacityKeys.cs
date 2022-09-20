using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Amos.Core.ResourceKey
{
    /// <summary>
    /// 不透明度相关的 key
    /// </summary>
    public class OpacityKeys
    {
        /// <summary>
        ///  不能使用的不透明度
        /// </summary>
        public static ComponentResourceKey Disable
        {
            get
            {
                return new ComponentResourceKey(typeof(OpacityKeys), "Opacity.Disable");
            }
        }

        /// <summary>
        /// 只读控件的不透明度
        /// </summary>
        public static ComponentResourceKey Readonly
        {
            get
            {
                return new ComponentResourceKey(typeof(OpacityKeys), "Opacity.Readonly");
            }
        }
    }
}
