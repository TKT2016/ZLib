using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZLangRT;
using ZLangRT.Attributes;

namespace Z桌面控件
{
    [ZMapping(typeof(Cursor))]
    public abstract class 光标
    {
        [ZCode("释放资源")]
        public abstract void Dispose();

        [ZCode("位置")]
        public static Point Position { get; set; }
    }
}
