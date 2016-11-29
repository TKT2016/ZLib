using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZLangRT;
using ZLangRT.Attributes;

namespace Z绘图
{
    [ZClass]
    public class 图片辅助
    {
        public static Image 图片(string file)
        {
            //Console.WriteLine("图片辅助.图片 file:"+file);
            string realFile = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase/*System.AppDomain.CurrentDomain.BaseDirectory*/, file);
            //Console.WriteLine("图片辅助.图片 realFile:" + realFile);
            //Console.WriteLine(File.Exists(file));
            //Console.WriteLine(File.Exists(realFile));
            return Image.FromFile(realFile);
        }
    }
}
