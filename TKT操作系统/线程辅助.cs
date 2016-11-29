using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ZLangRT;
using ZLangRT.Attributes;
using Z语言系统;

namespace Z操作系统
{
    [ZClass]
    public class 线程辅助
    {
        public static int 当前线程编号()
        {
            return Thread.CurrentThread.ManagedThreadId;
        }

    }
}
