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
    public class 文件夹辅助
    {
        public static bool 存在文件夹(string 文件夹名称)
        {
            return Directory.Exists(文件夹名称);
        }

        public static void 创建文件夹(string 文件夹名称)
        {
            Directory.CreateDirectory(文件夹名称);
        }

        public static void 删除文件夹(string 文件夹名称)
        {
            if (Directory.Exists(文件夹名称))
                Directory.Delete(文件夹名称);
        }

    }
}
