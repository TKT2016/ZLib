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
    public class 文本文件辅助
    {
        [ZCode("向文件(string:文件名称)追加写入文本(string:内容)")]
        public static void 追加写入文本(string 文件名称,string 内容)
        {
            using (StreamWriter toWrite = new StreamWriter(文件名称, false))
            {
                toWrite.Write(内容);
                toWrite.Close();
            }
        }

        [ZCode("向文件(string:文件名称)覆盖写入文本(string:内容)")]
        public static void 覆盖写入文本(string 文件名称, string 内容)
        {
            using (StreamWriter toWrite = new StreamWriter(文件名称, true))
            {
                toWrite.Write(内容);
                toWrite.Close();
            }
        }

        [ZCode("从(string:文件名称)读取文本")]
        public static string 读取文本(string 文件名称)
        {
            FileStream fs = File.OpenRead(文件名称);
            using (StreamReader reader = new StreamReader(fs))
            {
                string content = reader.ReadToEnd();
                reader.Close();
                return content;
            }
        }

    }
}
