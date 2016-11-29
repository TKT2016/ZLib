using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZLangRT;
using ZLangRT.Attributes;

namespace Z绘图.形状
{
    [ZClass]
    public class 矩形
    {
        public 矩形(int 长度, int 宽度)
        {
            this.长度 = 长度;
            this.宽度 = 宽度;
        }

        public int 长度 { get; set; }

        public int 宽度 { get; set; }

        public Point 左上角位置 { get; set; }
        public Point 左下角位置 { get { return new Point(左上角位置.X, 左上角位置.Y+宽度); } }
        public Point 右上角位置 { get { return new Point(左上角位置.X+长度, 左上角位置.Y ); } }
        public Point 右下角位置 { get { return new Point(左上角位置.X + 长度, 左上角位置.Y + 宽度); } }

        public Point 中心点
        {
            get
            {
                return new Point(左上角位置.X + 长度 / 2, 左上角位置.Y + 宽度 / 2);
            }
        }

        public bool 相交于(矩形 r)
        {
            if (containerPoint(r.左上角位置)) return true;
            if (containerPoint(r.左下角位置)) return true;
            if (containerPoint(r.右上角位置)) return true;
            if (containerPoint(r.右下角位置)) return true;
            return false;
        }

        [ZCode("包含(点:p)")]
        public bool containerPoint(Point p)
        {
            return (p.X >= 左上角位置.X && p.X <= 右下角位置.X) && (p.Y >= 左上角位置.Y && p.Y <= 右下角位置.Y );
        }

        public override string ToString()
        {
            return string.Format("矩形({0}*{1},[{2},{3},{4},{5}])", 长度, 宽度, 左上角位置, 左下角位置, 右上角位置, 右下角位置);
        }
    }
}
