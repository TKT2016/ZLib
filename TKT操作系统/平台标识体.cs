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
    [ZMapping(typeof(IntPtr))]
    public abstract class 平台标识体
    {
        [ZCode("转化为整数")]
        public abstract string ToInt32();

        [ZCode("(IntPtr:intPtr)接收消息(string:消息)")]
        public static void 接收消息(IntPtr intPtr, string 消息)
        {
            byte[] bytes = (ASCIIEncoding.ASCII.GetBytes(消息));
            for (int i = 0; i < bytes.Length; i++)
            {
                User32.SendMessage(intPtr, User32.WM_CHAR, (IntPtr)(bytes[i]), (IntPtr)0);
            }
        }

        [ZCode("(IntPtr:intPtr)有效")]
        public static bool 有效(IntPtr intPtr)
        {
            return intPtr != null && intPtr.ToInt64() > 0;
        }

        
    }
}
