using NSoup.Nodes;
using NSoup.Select;
using ZLangRT.Attributes;

namespace Z互联网
{
    [ZMapping(typeof(Document), typeof(网页元素))]
    public abstract class 网页文档 
    {
        [ZCode("标题")]
        public string Title { get; set; }

        [ZCode("头部")]
        public Element Head { get; set; }

        [ZCode("主体")]
        public Element Body { get; set; }
        /*
        [Code("根据(string:cssQuery)查询元素群")]
        public abstract Elements Select(string cssQuery);*/
    }
}
