﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZLangRT.Attributes;

namespace Z操作系统
{
     [ZClass]
    public class 定时器
    {
         System.Timers.Timer timer;

         public 定时器(int 间隔)
         {
             timer = new System.Timers.Timer();
             timer.AutoReset = true;
             timer.Elapsed += new System.Timers.ElapsedEventHandler(theout);//到达时间的时候执行事件；
             timer.Interval = 间隔;
         }

         private void theout(object source, System.Timers.ElapsedEventArgs e)
         {
            if(canRun())
            {
                run();
            }
         }

         private void run()
         {
             if (运行内容 != null)
             {
                 运行内容();
             }
         }


         private bool canRun()
         {
             if (停止条件 == null) return true;
             return !停止条件();
         }

         public Action 运行内容 { get; set; }
         public Func<bool> 停止条件 { get; set; }
         public int 间隔 { get { return (int)(timer.Interval); } set { timer.Interval = value; } }

         public void 停止()
         {
             timer.Enabled = false;
         }

         public void 启动()
         {
             timer.Enabled = true;
             timer.Start();
         }
    }
}
