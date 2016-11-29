using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZLangRT.Attributes;

namespace Z文件系统
{
    [ZClass]
    public class 文件辅助
    {
        public static bool 存在文件(string 文件名称)
        {
            return File.Exists(文件名称);
        }

        public static void 创建文件(string 文件名称)
        {
            File.Create(文件名称);
        }

        public static void 删除文件(string 文件名称)
        {
            if (File.Exists(文件名称))
                File.Delete(文件名称);
        }
    }
}
