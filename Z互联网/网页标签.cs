using NSoup.Parse;
using ZLangRT.Attributes;

namespace Z互联网
{
    [ZMapping(typeof(Tag))]
    public class 网页标签
    {
        [ZCode("名称")]
        public string Name { get; set; }

        [ZCode("上级标签")]
        public Tag Parent { get; set; }
    }
}
