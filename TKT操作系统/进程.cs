using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ZLangRT;
using ZLangRT.Attributes;

namespace Z操作系统
{
    [ZMapping(typeof(Process))]
    public abstract class 进程
    {
        [ZCode("进程名称")]
        public string ProcessName { get; set; }

        [ZCode("主窗口标识体")]
        public string MainWindowHandle { get; set; }

        [ZCode("(Process:process)接收消息(string:消息)")]
        public static bool 接收消息(Process process, string 消息)
        {
            if(平台标识体.有效(process.MainWindowHandle))
            {
                var ptrEx = User32.FindWindowEx(process.MainWindowHandle, IntPtr.Zero, "Edit", "");
                平台标识体.接收消息(ptrEx, 消息);
                return true;
            }
            return false;
        }

        [ZCode("关闭")]
        public abstract void Close();

        [ZCode("终止")]
        public abstract void Kill();

    }
}
