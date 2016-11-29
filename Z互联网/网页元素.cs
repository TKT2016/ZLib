using ZLangRT.Attributes;
using Z语言系统;

namespace Z互联网
{
    [ZMapping(typeof(NSoup.Nodes.Element),typeof(网页节点))]
    public abstract class 网页元素
    {
        [ZCode("ID")]
        public string Id { get; set; }

        [ZCode("获取CSS类名称")]
        public abstract string ClassName();

        [ZCode("获取HTML文本")]
        public abstract string Html();

        [ZCode("获取文本内容")]
        public abstract string Text();

        [ZCode("(Element:element)根据(string:cssQuery)查询子元素")]
        public static 列表<NSoup.Nodes.Element> Select(NSoup.Nodes.Element element,string cssQuery)
        {
            NSoup.Select.Elements elements = element.Select(cssQuery);
            NSoup.Nodes.Element[] earray = elements.ToArray();
            列表<NSoup.Nodes.Element> list = new 列表<NSoup.Nodes.Element>(earray);
            return list;
        }

        [ZCode("获取标签名称")]
        public abstract string TagName();

        [ZCode("获取(string:attributeKey)属性的文本")]
        public abstract string Attr(string attributeKey);

    }
}
