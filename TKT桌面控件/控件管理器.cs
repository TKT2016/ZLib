using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZLangRT;
using ZLangRT.Attributes;

namespace Z桌面控件
{
    [ZMapping(typeof(Application))]
    public class 控件管理器 
    {
        public static void 初始化()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        public static void 启动窗体(Form form)
        {
            //Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory); 
            Application.Run(form);
        }

    }
}
