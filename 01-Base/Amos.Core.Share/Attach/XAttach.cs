using System;
using System.Collections.Generic;
using System.Text;

namespace Amos.Core.Attach
{
    /**
     * 设计原则:
     * 使用部分类将各个不同的附加属性分到不同的文件中来写，只是为了方便结构的设计
     * 对于公共使用的附加属性，放到此文件中
     * 其他针对特定控件的附加属性放到 XAttach.XXX.cs文件中
     */

    /// <summary>
    /// 公共附加属性
    /// </summary>
    public static partial class XAttach
    {

    }
}
