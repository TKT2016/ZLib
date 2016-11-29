using NSoup;
using NSoup.Nodes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZLangRT.Attributes;
using Z文件系统;

namespace Z互联网
{
    [ZClass]
    public class 互联网辅助
    {
        [ZCode("从(string:网址)获取网页源码")]
        public static string 获取HTML(string 网址)
        {
            string html = HttpHelper.GetHtml(网址);
            return html;
        }

        [ZCode("从(string:网址)下载文件到(string:文件夹)")]
        public static void 下载文件(string 文件网址,string 文件夹)
        {
            if (!文件夹辅助.存在文件夹(文件夹))
                文件夹辅助.创建文件夹(文件夹);
            string newFilePath = Path.Combine(文件夹,PictureDownUtil.GetFileNameByUrl(文件网址));
            PictureDownUtil.SavePhotoFromUrl(文件网址, newFilePath);
        }

        [ZCode("从(string:网址)解析网页文档")]
        public static Document 解析网页文档(string 网址)
        {
            string html = 互联网辅助.获取HTML(网址);
            Document doc = NSoupClient.Parse(html);
            return doc;
        }
    }
}
