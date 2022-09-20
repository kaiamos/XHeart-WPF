using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Amos.Core.ResourceKey
{
    /// <summary>
    /// 颜色相关的 key
    /// </summary>
    public class BrushKeys
    {

        #region 背景色
        /// <summary>
        /// 默认背景色
        /// </summary>
        public static ComponentResourceKey DefaultBackground
        {
            get { return new ComponentResourceKey(typeof(BrushKeys), "Brush.Backgorund.Default"); }
        }


        #endregion

        #region 前景色
        /// <summary>
        /// 默认前景色
        /// </summary>
        public static ComponentResourceKey DefaultForeground
        {
            get { return new ComponentResourceKey(typeof(BrushKeys), "Brush.Foreground.Default"); }
        }

        /// <summary>
        /// 默认文字的前景色
        /// </summary>
        public static ComponentResourceKey TextForeground
        {
            get { return new ComponentResourceKey(typeof(BrushKeys), "Brush.Foreground.Text"); }
        }

        #endregion
    }
}
