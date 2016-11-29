using System;
using System.Drawing;
using ZLangRT;
using ZLangRT.Attributes;

namespace Z绘图.形状
{
    [ZMapping(typeof(Point))]
    public class 点
    {
        [ZCode("X坐标")]
        public int X { get; set; }

        [ZCode("Y坐标")]
        public int Y { get; set; }
    }
}
